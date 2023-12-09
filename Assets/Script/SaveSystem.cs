using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveSystem : MonoBehaviour
{
    public static SaveSystem instance;
    public AnimalInfo animalsInfo;

    void Start()
    {
        instance = this;
        Load();
    }

    public void Load()
    {


        if (File.Exists(Application.persistentDataPath + "/data.save"))
        {
            string json = File.ReadAllText(Application.persistentDataPath + "/data.save");
            animalsInfo = JsonUtility.FromJson<AnimalInfo>(json);

            AnimalScript[] allAnimals = FindObjectsOfType(typeof(AnimalScript)) as AnimalScript[];
            for(int i = 0; i <= allAnimals.Length; i++)
            {
                Vector3 animalPosition = allAnimals[i].transform.position;

                allAnimals[i].nameAnimal = animalsInfo.animals[i].nameAnimal;
                allAnimals[i].age = animalsInfo.animals[i].age;

                allAnimals[i].thirst = animalsInfo.animals[i].thirst;
                allAnimals[i].hunger = animalsInfo.animals[i].hunger;
                allAnimals[i].tiredness = animalsInfo.animals[i].tiredness;

                animalPosition.x = animalsInfo.animals[i].x;
                animalPosition.y = animalsInfo.animals[i].y;
                animalPosition.z = animalsInfo.animals[i].z;

                allAnimals[i].food = animalsInfo.animals[i].food;
                allAnimals[i].state = animalsInfo.animals[i].state;
            }
        }

    }

    public void Save()
    {
        animalsInfo.animals.Clear();
        AnimalScript[] allAnimals = FindObjectsOfType(typeof(AnimalScript)) as AnimalScript[];

        foreach (AnimalScript animal in allAnimals)
        {
            Vector3 position = animal.transform.position;
            animalsInfo.animals.Add(new AnimalSave() { nameAnimal = animal.nameAnimal, age = animal.age , hunger = animal.hunger, thirst = animal.thirst, tiredness = animal.tiredness, x = position.x, y = position.y, z = position.z, food = animal.food, state = animal.state });
        }

        Debug.Log(Application.persistentDataPath + "/data.save");
        string json = JsonUtility.ToJson(animalsInfo);
        if (!File.Exists(Application.persistentDataPath + "/data.save"))
        {
            File.Create(Application.persistentDataPath + "/data.save").Dispose();
        }
        File.WriteAllText(Application.persistentDataPath + "/data.save", json);

    }

    public void DeleteFile()
    {
        string json = Application.persistentDataPath + "/data.save";

        // check if file exists
        if (!File.Exists(json))
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            File.Delete(json);
            SceneManager.LoadScene(0);
        }
    }
}

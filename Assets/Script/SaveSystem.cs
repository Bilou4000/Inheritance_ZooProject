using System.IO;
using UnityEngine;
using static UnityEditor.Progress;

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
                allAnimals[i].thirst = animalsInfo.animals[i].thirst;
                allAnimals[i].hunger = animalsInfo.animals[i].hunger;
                allAnimals[i].tiredness = animalsInfo.animals[i].tiredness;
            }
        }

    }

    public void Save()
    {
        animalsInfo.animals.Clear();
        AnimalScript[] allAnimals = FindObjectsOfType(typeof(AnimalScript)) as AnimalScript[];
        foreach (AnimalScript animal in allAnimals)
        {
            animalsInfo.animals.Add(new AnimalSave() { hunger = animal.hunger, thirst = animal.thirst, tiredness = animal.tiredness });
        }

        //Vector3 position = PlayerMovement.instance.transform.position;
        //player.x = position.x;
        //player.y = position.y;
        //player.z = position.z;

        //player.inventory.Clear();
        //foreach (Item item in PlayerInventory.Instance.GetInventory())
        //{
        //    player.inventory.Add(new SaveItem() { id = item.uniqueID, spriteName = item.icon.name });
        //    Debug.Log(item.icon.name);
        //}


        Debug.Log(Application.persistentDataPath + "/data.save");
        string json = JsonUtility.ToJson(animalsInfo);
        if (!File.Exists(Application.persistentDataPath + "/data.save"))
        {
            File.Create(Application.persistentDataPath + "/data.save").Dispose();
        }
        File.WriteAllText(Application.persistentDataPath + "/data.save", json);

    }
}

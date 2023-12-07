using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class AnimalScript : MonoBehaviour
{
    public static AnimalScript instance;

    public GameObject nameOfAnimal;
    public GameObject canva;
    public GameObject drinkBar;
    public GameObject foodBar;

    private GameObject newName;
    private GameObject drink;
    private GameObject foodFill;
    private GameObject mouseFood;

    private Image drinkImage;
    private Image foodImage;
    private TMP_Text textOfAnimal;
    private protected SpriteRenderer spriteRenderer;
    private Color baseColor;
    
    public float age;
    private protected float getTired;
    private protected float moveSpeed, chillSpeed, startmoveSpeed, startchillSpeed;
    private protected bool feed = false, isSleeping = false, drinkingWater = false, canMove = false;
    private protected Vector3 direction = Vector3.zero;
    private string[] nameList = new string[] { "Minet", "Félix", "Médor", "Rex", "Moustache", "Câline", "Peluche", "Bambi", "Nala", "Simba", "Gribouille", "Choupi", "Bella", "Oscar", "Luna", "Shadow", "Lucky", "Pacha", "Milo", "Oliver", "Cookie", "Tigrou", "Minnie", "Charlie", "Lola", "Coco", "Rocky", "Chouchou", "Belle", "Snoopy", "Ziggy", "Daisy", "Mickey", "Sushi", "Gizmo", "Maya", "Dobby", "Buddy", "Pumpkin", "Mocha", "Whiskers", "Zorro", "Mochi", "Lulu", "Peanut", "Zigzag", "Pixel", "Ginger", "Felix", "Pippin", "Misty", "Blue", "Kiwi", "Snickers", "Socks", "Mango", "Cinnamon", "Rosie", "Taz", "Casper", "Marley", "Pebbles", "Twix", "Pumpkin", "Cleo", "Bubbles", "Sunny", "Pepper", "Bentley", "Jasper", "Juno", "Scooby", "Tucker", "Rusty", "Kiki", "Loki", "Tofu", "Leo", "Mochi", "Marshmallow", "Snickerdoodle", "Pixie", "Chester", "Coco", "Maddie", "Rocky", "Apollo", "Oreo", "Lily", "Noodle", "Ziggy", "Tesla" };
    public string nameAnimal;

    private protected float timer;
    
    public StateOfAnimal state;
    public TypeOfFood food;
    public Skeleton skeleton;
    public Blood blood;
    public Habitat habitat;
    public Reproduction reproduction;

    [Range(0,100)]
    public float hunger = 100, thirst = 100, tiredness = 100;

    private void Awake()
    {
        age = Random.Range(1, 30);
        nameAnimal = nameList[Random.Range(0, nameList.Length)];

        instance = this;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    protected virtual void Start()
    {
        Time.timeScale = 1;

        baseColor = spriteRenderer.color;
        getTired = Random.Range(0.5f, 5);

        InvokeRepeating("decreaseHunger", 1.0f, 1.0f);
        InvokeRepeating("decreaseThirst", 1.0f, 1.0f);
        InvokeRepeating("decreaseTiredness", 1.0f, 1.0f);

        newName = Instantiate(nameOfAnimal, Camera.main.WorldToScreenPoint(gameObject.transform.position) + new Vector3(0, 12, 0), Quaternion.identity);
        newName.transform.SetParent(canva.transform, true);
        newName.transform.SetSiblingIndex(0);
        textOfAnimal = newName.GetComponent<TMP_Text>();
        textOfAnimal.text = nameAnimal;

        drink = Instantiate(drinkBar, Camera.main.WorldToScreenPoint(gameObject.transform.position) + new Vector3(15, 20, 0), Quaternion.identity);
        drink.transform.SetParent(canva.transform, true);
        drink.transform.SetSiblingIndex(0);

        drinkImage = drink.GetComponentsInChildren<Image>()[1];

        foodFill = Instantiate(foodBar, Camera.main.WorldToScreenPoint(gameObject.transform.position) + new Vector3(-15, 20, 0), Quaternion.identity);
        foodFill.transform.SetParent(canva.transform, true);
        foodFill.transform.SetSiblingIndex(0);

        foodImage = foodFill.GetComponentsInChildren<Image>()[1];

        drink.SetActive(false);
        foodFill.SetActive(false);

        startmoveSpeed = moveSpeed;
        startchillSpeed = chillSpeed;
    }

    void decreaseHunger()
    {
        if (hunger > 0 && state != StateOfAnimal.Eating && state != StateOfAnimal.Sleep)
        {
            hunger -= 0.2f;
        }
    }

    void decreaseThirst()
    {
        if (thirst > 0 && state != StateOfAnimal.Drinking && state != StateOfAnimal.Sleep)
        {
            thirst -= 0.5f;
        }
    }

    void decreaseTiredness()
    {
        if (state != StateOfAnimal.Sleep)
        {
            if (tiredness > 0)
            {
                tiredness -= getTired;
            }
        }

    }

    protected virtual void Update()
    {
        textOfAnimal.text = nameAnimal;

        drinkImage.fillAmount = thirst / 100;
        foodImage.fillAmount = hunger / 100;


        newName.transform.position = Camera.main.WorldToScreenPoint(gameObject.transform.position) + new Vector3(0, 12, 0);
        drink.transform.position = Camera.main.WorldToScreenPoint(gameObject.transform.position) + new Vector3(15, 30, 0);
        foodFill.transform.position = Camera.main.WorldToScreenPoint(gameObject.transform.position) + new Vector3(-15, 30, 0);

        if (canMove == false)
        {
            direction = new Vector3 (Random.insideUnitSphere.x, Random.insideUnitSphere.y, 0);
        }
        

        switch (state)
        {
            case StateOfAnimal.MoveAround:
                canMove = true;  
                transform.position += direction * moveSpeed * Time.deltaTime;
                spriteRenderer.color = baseColor;
                break;
            case StateOfAnimal.Chill:
                canMove = true;
                transform.position += direction * chillSpeed * Time.deltaTime;
                spriteRenderer.color = baseColor;
                break;
            case StateOfAnimal.Eating:
                canMove = false;
                feed = true;
                spriteRenderer.color = new Color(255 / 255f, 51 / 255f, 51 / 255f);
                break;
            case StateOfAnimal.Drinking:
                canMove = false;
                drinkingWater = true;
                spriteRenderer.color = new Color(102 / 255f, 194 / 255f, 255 / 255f);
                Invoke("Drink", 2f);
                break;
            case StateOfAnimal.Sleep:
                isSleeping = true;
                canMove = false;
                spriteRenderer.color = Color.black;
                break;
        }

        if(tiredness >= 80 && isSleeping == true)
        {
            isSleeping = false;
            state = (StateOfAnimal)Random.Range(0, 2);
        }

        if (tiredness <= 5)
        {
            state = StateOfAnimal.Sleep;
        }

        if (state == StateOfAnimal.Sleep)
        {
            timer += Time.deltaTime;
        }

        if (timer >= 1)
        {
            timer = 0f;
            tiredness += 15;
        }
    }

    private void OnMouseOver()
    {
        drink.SetActive(true);
        foodFill.SetActive(true);
        moveSpeed = 0;
        chillSpeed = 0;
    }

    private void OnMouseExit()
    {
        drink.SetActive(false);
        foodFill.SetActive(false);
        moveSpeed = startmoveSpeed;
        chillSpeed = startchillSpeed;
    }

    public void Hunger()
    {
        if (hunger <= 100 && feed == true)
        {
            hunger += 40;
            state = (StateOfAnimal)Random.Range(0, 2);
            Debug.Log("That was good");
        }
        else if(hunger > 70 && feed == true)
        {
            Debug.Log("The animal can't eat more");
            state = (StateOfAnimal)Random.Range(0, 2);
        }
        feed = false;      
    }

    public void Drink()
    {
        if (thirst <= 100 && drinkingWater == true)
        {
            thirst += 40;
            state = (StateOfAnimal)Random.Range(0, 2);
            Debug.Log("That was good");
        }
        else if (thirst > 70 && drinkingWater == true)
        {
            Debug.Log("The animal can't drink more");
            state = (StateOfAnimal)Random.Range(0, 2);
        }
        drinkingWater = false;
    }

    private void OnMouseDown()
    {
        if(ManagerScript.instance.theFood.tag == "Fish")
        {
            //if (state != StateOfAnimal.Sleep && state != StateOfAnimal.Eating)
            food = TypeOfFood.Fish;
            state = StateOfAnimal.Eating;
        }

        if (ManagerScript.instance.theFood.tag == "Mollusc")
        {
            food = TypeOfFood.Mollusc;
            state = StateOfAnimal.Eating;
        }

        if (ManagerScript.instance.theFood.tag == "Seed")
        {
            food = TypeOfFood.Seed;
            state = StateOfAnimal.Eating;
        }

        if (ManagerScript.instance.theFood.tag == "Grass")
        {
            food = TypeOfFood.Grass;
            state = StateOfAnimal.Eating;
        }

        if (ManagerScript.instance.theFood.tag == "Meat")
        {
            food = TypeOfFood.Meat;
            state = StateOfAnimal.Eating;
        }

        if (ManagerScript.instance.theFood.tag == "Water")
        {
            state = StateOfAnimal.Drinking;
        }

        Destroy(ManagerScript.instance.theFood);
    }

    public enum TypeOfFood
    {
        Fish,
        Mollusc,
        Seed,
        Grass,
        Meat,
        Everything
    }

    public enum StateOfAnimal
    {
        Chill,
        MoveAround,
        Sleep,
        Eating,
        Drinking
    }

    public enum Skeleton
    {
        Invertebrate,
        Vertebrate
    }

    public enum Blood
    {
        ColdBlooded,
        HotBlooded
    }

    public enum Habitat
    {
        Land,
        Water
    }

    public enum Reproduction
    {
        Oviparous,
        Viviparous
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        moveSpeed = -moveSpeed;
        chillSpeed = -chillSpeed;   
    }
}

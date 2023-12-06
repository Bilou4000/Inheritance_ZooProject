using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class AnimalScript : MonoBehaviour
{
    public Image drinkBar;
    public Image hungerBar;
    public GameObject nameOfAnimal;
    public GameObject canva;
    public GameObject foodPanel;
    private GameObject newName;
    //private GameObject[] allAnimals;
    private TMP_Text textOfAnimal;
    private protected SpriteRenderer spriteRenderer;
    private Color baseColor;

    public string name;
    public float age;
    private protected float getTired;
    private protected float moveSpeed, chillSpeed;
    private protected bool feed = false, isSleeping = false, drinkingWater = false, canMove = false;
    private protected Vector3 direction = Vector3.zero;

    private protected float timer;
    
    public State state;
    public TypeOfFood food;
    public Skeleton skeleton;
    public Blood blood;
    public Habitat habitat;
    public Reproduction reproduction;

    [Range(0,100)]
    public float hunger = 100, thirst = 100, tiredness = 100;

    private void Awake()
    {
        //allAnimals = GameObject.FindGameObjectsWithTag(gameObject.tag);
        spriteRenderer = GetComponent<SpriteRenderer>();      
    }

    // Start is called before the first frame update
    protected virtual void Start()
    {

        Time.timeScale = 1;
        foodPanel.SetActive(false);

        baseColor = spriteRenderer.color;
        getTired = Random.Range(0.5f, 5);
        age = Random.Range(1, 30);

        InvokeRepeating("decreaseHunger", 1.0f, 1.0f);
        InvokeRepeating("decreaseThirst", 1.0f, 1.0f);
        InvokeRepeating("decreaseTiredness", 1.0f, 1.0f);

        newName = Instantiate(nameOfAnimal, Camera.main.WorldToScreenPoint(gameObject.transform.position) + new Vector3(0, 12, 0), Quaternion.identity);
        newName.transform.SetParent(canva.transform, true);
        newName.transform.SetSiblingIndex(0);
        textOfAnimal = newName.GetComponent<TMP_Text>();
        textOfAnimal.text = name;
    }

    void decreaseHunger()
    {
        if (hunger > 0 && state != State.Eating && state != State.Sleep)
        {
            hunger -= 1;
        }
    }

    void decreaseThirst()
    {
        if (thirst > 0 && state != State.Drinking && state != State.Sleep)
        {
            thirst -= 2;
        }
    }

    void decreaseTiredness()
    {
        if (state != State.Sleep)
        {
            if (tiredness > 0)
            {
                tiredness -= getTired;
            }
        }

    }

    // Update is called once per frame
    protected virtual void Update()
    {
        drinkBar.fillAmount = thirst / 100;
        hungerBar.fillAmount = hunger / 100;
        newName.transform.position = Camera.main.WorldToScreenPoint(gameObject.transform.position) + new Vector3(0, 12, 0);

        if(canMove == false)
        {
            direction = new Vector3 (Random.insideUnitSphere.x, Random.insideUnitSphere.y, 0);
        }
        

        switch (state)
        {
            case State.MoveAround:
                canMove = true;  
                transform.position += direction * moveSpeed * Time.deltaTime;
                spriteRenderer.color = baseColor;
                break;
            case State.Chill:
                canMove = true;
                transform.position += direction * chillSpeed * Time.deltaTime;
                spriteRenderer.color = baseColor;
                break;
            case State.Eating:
                canMove = false;
                feed = true;
                spriteRenderer.color = new Color(255 / 255f, 51 / 255f, 51 / 255f);
                break;
            case State.Drinking:
                canMove = false;
                drinkingWater = true;
                spriteRenderer.color = new Color(102 / 255f, 194 / 255f, 255 / 255f);
                Invoke("Drink", 2f);
                break;
            case State.Sleep:
                isSleeping = true;
                canMove = false;
                spriteRenderer.color = Color.black;
                break;
        }

        if(tiredness >= 80 && isSleeping == true)
        {
            isSleeping = false;
            state = (State)Random.Range(0, 2);
            Debug.Log("The animal have slept enough");
        }

        if (tiredness <= 5)
        {
            state = State.Sleep;
        }

        if (state == State.Sleep)
        {
            timer += Time.deltaTime;
        }

        if (timer >= 1)
        {
            timer = 0f;
            tiredness += 15;
        }
    }

    public void GiveWater()
    {
        if (state != State.Sleep && state != State.Eating)
        {
            state = State.Drinking;
        }
    }

    public void Feed()
    {
        if(state != State.Sleep && state != State.Drinking)
        {
            Time.timeScale = 0;
            foodPanel.SetActive(true);
        }     
    }

    public void Hunger()
    {
        if (hunger <= 70 && feed == true)
        {
            hunger += 30;
            state = (State)Random.Range(0, 2);
            Debug.Log("That was good");
        }
        else if(hunger > 70 && feed == true)
        {
            Debug.Log("The animal can't eat more");
            state = (State)Random.Range(0, 2);
        }
        feed = false;

        
    }

    public void Drink()
    {
        if (thirst <= 70 && drinkingWater == true)
        {
            thirst += 30;
            state = (State)Random.Range(0, 2);
            Debug.Log("That was good");
        }
        else if (thirst > 70 && drinkingWater == true)
        {
            Debug.Log("The animal can't drink more");
            state = (State)Random.Range(0, 2);
        }
        drinkingWater = false;
    }

    public void Fish()
    {
        food = TypeOfFood.Fish;
        state = State.Eating;
        foodPanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void Mollusc()
    {
        food = TypeOfFood.Mollusc;
        state = State.Eating;
        foodPanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void Seed()
    {
        food = TypeOfFood.Seed;
        state = State.Eating;
        foodPanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void Grass()
    {
        food = TypeOfFood.Grass;
        state = State.Eating;
        foodPanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void Meat()
    {
        food = TypeOfFood.Meat;
        state = State.Eating;
        foodPanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void RandomFood()
    {
        food = (TypeOfFood)Random.Range(0,6);
        state = State.Eating;
        foodPanel.SetActive(false);
        Time.timeScale = 1;
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

    public enum State
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

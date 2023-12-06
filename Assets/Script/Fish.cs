using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : SeaAnimal
{

    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 10;
        chillSpeed = 5f;

        base.Start();
        food = (TypeOfFood)Random.Range(0, 2);
        blood = Blood.ColdBlooded;
        reproduction = Reproduction.Oviparous;
    }

    // Update is called once per frame
    void Update()
    {
        base.Update();

        switch (food)
        {
            case TypeOfFood.Meat:
                if (state == State.Eating)
                {
                    if (feed == true)
                    {
                        state = (State)Random.Range(0, 2);
                        Debug.Log("That food is disgusting");
                    }

                    feed = false;
                }
                break;
            case TypeOfFood.Fish:
                if (state == State.Eating)
                {
                    Invoke("Hunger", 2f);
                }
                break;
            case TypeOfFood.Mollusc:
                if (state == State.Eating)
                {
                    Invoke("Hunger", 2f);
                }
                break;
            case TypeOfFood.Seed:
                if (state == State.Eating)
                {
                    if (feed == true)
                    {
                        state = (State)Random.Range(0, 2);
                        Debug.Log("Is this poison ?");
                    }

                    feed = false;
                }
                break;
            case TypeOfFood.Grass:
                if (state == State.Eating)
                {
                    if (feed == true)
                    {
                        state = (State)Random.Range(0, 2);
                        Debug.Log("Do you want to kill me ?");
                    }

                    feed = false;

                }
                break;
            case TypeOfFood.Everything:
                if (state == State.Eating)
                {
                    if (feed == true)
                    {
                        state = (State)Random.Range(0, 2);
                        Debug.Log("What even is this");
                    }

                    feed = false;
                }
                break;
        }
    }
}

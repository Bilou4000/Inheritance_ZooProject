using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static AnimalScript;

public class PinFlamingo : OviparusHotBlooded
{
    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 6;
        chillSpeed = 0.2f;

        spriteRenderer.color = new Color(255 / 255f, 153 / 255f, 204 / 255f);
        food = TypeOfFood.Mollusc;
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        base.Update();

        switch (food)
        {
            case TypeOfFood.Meat:
                if (state == StateOfAnimal.Eating)
                {
                    if (feed == true)
                    {
                        state = (StateOfAnimal)Random.Range(0, 2);
                        Debug.Log("That food is disgusting");
                    }

                    feed = false;
                }
                break;
            case TypeOfFood.Fish:
                if (state == StateOfAnimal.Eating)
                {
                    if (feed == true)
                    {
                        state = (StateOfAnimal)Random.Range(0, 2);
                        Debug.Log("I'm not in the mood right now");
                    }

                    feed = false;
                }
                break;
            case TypeOfFood.Mollusc:
                if (state == StateOfAnimal.Eating)
                {
                    Invoke("Hunger", 2f);
                }
                break;
            case TypeOfFood.Seed:
                if (state == StateOfAnimal.Eating)
                {
                    if (feed == true)
                    {
                        state = (StateOfAnimal)Random.Range(0, 2);
                        Debug.Log("Is this poison ?");
                    }

                    feed = false;
                }
                break;
            case TypeOfFood.Grass:
                if (state == StateOfAnimal.Eating)
                {
                    if (feed == true)
                    {
                        state = (StateOfAnimal)Random.Range(0, 2);
                        Debug.Log("Do you want to kill me ?");
                    }

                    feed = false;
                }
                break;
            case TypeOfFood.Everything:
                if (state == StateOfAnimal.Eating)
                {
                    if (feed == true)
                    {
                        state = (StateOfAnimal)Random.Range(0, 2);
                        Debug.Log("What even is this");
                    }

                    feed = false;
                }
                break;
        }
    }
}

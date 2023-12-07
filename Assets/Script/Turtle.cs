using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static AnimalScript;

public class Turtle : OviparusColdBlooded
{

    // Start is called before the first frame update
    protected override void Start()
    {
        moveSpeed = 2;
        chillSpeed = 0.5f;

        spriteRenderer.color = new Color(102 / 255f, 255 / 255f, 102 / 255f);
        food = TypeOfFood.Grass;
        base.Start();
    }

    // Update is called once per frame
    protected override void Update()
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
                        Debug.Log("Do you want to kill me ?");
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
                    if (feed == true)
                    {
                        state = (StateOfAnimal)Random.Range(0, 2);
                        Debug.Log("That food is disgusting");
                    }

                    feed = false;
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
                    Invoke("Hunger", 2f);
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

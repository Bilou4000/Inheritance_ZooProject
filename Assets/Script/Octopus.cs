using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static AnimalScript;

public class Octopus : AnimalInvertebrate
{
    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 6;
        chillSpeed = 0.3f;

        spriteRenderer.color = new Color(102 / 255f, 153 / 255f, 255 / 255f);
        food = TypeOfFood.Mollusc;
        blood = Blood.ColdBlooded;
        habitat = Habitat.Water;
        reproduction = Reproduction.Oviparous;
        base.Start();
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
                    if (feed == true)
                    {
                        state = (State)Random.Range(0, 2);
                        Debug.Log("I'm not in the mood right now");
                    }

                    feed = false;
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

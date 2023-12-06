using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static AnimalScript;

public class Racoon : ViviparusAnimal
{

    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 5;
        chillSpeed = 2;

        spriteRenderer.color = new Color(112 / 255f, 104 / 255f, 101 / 255f);
        food = TypeOfFood.Everything;
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
                    Invoke("Hunger", 2f);
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
                    Invoke("Hunger", 2f);
                }
                break;
            case TypeOfFood.Grass:
                if (state == State.Eating)
                {
                    Invoke("Hunger", 2f);
                }
                break;
            case TypeOfFood.Everything:
                if (state == State.Eating)
                {
                    Invoke("Hunger", 2f);
                }
                break;
        }
    }
}

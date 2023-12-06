using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerScript : MonoBehaviour
{
    public GameObject racoonPanel;
    public GameObject crocodilePanel;
    public GameObject giraffePanel;
    public GameObject flamingosPanel;
    public GameObject pinguinsPanel;
    public GameObject octopusPanel;
    public GameObject turtlePanel;
    public GameObject fishPanel;

    private GameObject[] racoons;
    private GameObject[] crocodile;
    private GameObject[] giraffe;
    private GameObject[] flamingos;
    private GameObject[] pinguins;
    private GameObject[] octopus;
    private GameObject[] turtle;
    private GameObject[] fish;

    // Start is called before the first frame update
    void Start()
    {
        racoons = GameObject.FindGameObjectsWithTag("Racoon");
        crocodile = GameObject.FindGameObjectsWithTag("Crocodile");
        giraffe = GameObject.FindGameObjectsWithTag("Giraffe");
        flamingos = GameObject.FindGameObjectsWithTag("Flamingo");
        pinguins = GameObject.FindGameObjectsWithTag("Pinguin");
        octopus = GameObject.FindGameObjectsWithTag("Octopus");
        turtle = GameObject.FindGameObjectsWithTag("Turtle");
        fish = GameObject.FindGameObjectsWithTag("Fish");
    }


    //DRINK
    public void RacoonDrink()
    {
        foreach (GameObject go in racoons)
        {
            go.GetComponent<AnimalScript>().GiveWater();
        }
    }

    public void CrocodileDrink()
    {
        foreach (GameObject go in crocodile)
        {
            go.GetComponent<AnimalScript>().GiveWater();
        }
    }

    public void GiraffeDrink()
    {
        foreach (GameObject go in giraffe)
        {
            go.GetComponent<AnimalScript>().GiveWater();
        }
    }

    public void FlamingosDrink()
    {
        foreach (GameObject go in flamingos)
        {
            go.GetComponent<AnimalScript>().GiveWater();
        }
    }

    public void PinguinsDrink()
    {
        foreach (GameObject go in pinguins)
        {
            go.GetComponent<AnimalScript>().GiveWater();
        }
    }
    public void OctopusDrink()
    {
        foreach (GameObject go in octopus)
        {
            go.GetComponent<AnimalScript>().GiveWater();
        }
    }
    public void TurtleDrink()
    {
        foreach (GameObject go in turtle)
        {
            go.GetComponent<AnimalScript>().GiveWater();
        }
    }
    public void FishDrink()
    {
        foreach (GameObject go in fish)
        {
            go.GetComponent<AnimalScript>().GiveWater();
        }
    }

    //FOOD
    public void RacoonFood()
    {
        foreach (GameObject go in racoons)
        {
            go.GetComponent<AnimalScript>().Feed();
        }
    }

    public void CrocodileFood()
    {
        foreach (GameObject go in crocodile)
        {
            go.GetComponent<AnimalScript>().Feed();
        }
    }

    public void GiraffeFood()
    {
        foreach (GameObject go in giraffe)
        {
            go.GetComponent<AnimalScript>().Feed();
        }
    }

    public void FlamingosFood()
    {
        foreach (GameObject go in flamingos)
        {
            go.GetComponent<AnimalScript>().Feed();
        }
    }

    public void PinguinsFood()
    {
        foreach (GameObject go in pinguins)
        {
            go.GetComponent<AnimalScript>().Feed();
        }
    }
    public void OctopusFood()
    {
        foreach (GameObject go in octopus)
        {
            go.GetComponent<AnimalScript>().Feed();
        }
    }
    public void TurtleFood()
    {
        foreach (GameObject go in turtle)
        {
            go.GetComponent<AnimalScript>().Feed();
        }
    }
    public void FishesFood()
    {
        foreach (GameObject go in fish)
        {
            go.GetComponent<AnimalScript>().Feed();
        }
    }

    public void FishFood()
    {
        if (racoonPanel.activeSelf == true)
        {
            foreach(GameObject go in racoons)
            {
                go.gameObject.GetComponent<AnimalScript>().Fish();
            }
        }

        if (crocodilePanel.activeSelf == true)
        {
            foreach (GameObject go in crocodile)
            {
                go.gameObject.GetComponent<AnimalScript>().Fish();
            }
        }

        if (flamingosPanel.activeSelf == true)
        {
            foreach (GameObject go in flamingos)
            {
                go.gameObject.GetComponent<AnimalScript>().Fish();
            }
        }

        if (giraffePanel.activeSelf == true)
        {
            foreach (GameObject go in giraffe)
            {
                go.gameObject.GetComponent<AnimalScript>().Fish();
            }
        }

        if (pinguinsPanel.activeSelf == true)
        {
            foreach (GameObject go in pinguins)
            {
                go.gameObject.GetComponent<AnimalScript>().Fish();
            }
        }

        if (octopusPanel.activeSelf == true)
        {
            foreach (GameObject go in octopus)
            {
                go.gameObject.GetComponent<AnimalScript>().Fish();
            }
        }

        if (turtlePanel.activeSelf == true)
        {
            foreach (GameObject go in turtle)
            {
                go.gameObject.GetComponent<AnimalScript>().Fish();
            }
        }

        if (fishPanel.activeSelf == true)
        {
            foreach (GameObject go in fish)
            {
                go.gameObject.GetComponent<AnimalScript>().Fish();
            }
        }
    }

    public void MolluscFood()
    {
        if (racoonPanel.activeSelf == true)
        {
            foreach (GameObject go in racoons)
            {
                go.gameObject.GetComponent<AnimalScript>().Mollusc();
            }
        }

        if (crocodilePanel.activeSelf == true)
        {
            foreach (GameObject go in crocodile)
            {
                go.gameObject.GetComponent<AnimalScript>().Mollusc();
            }
        }

        if (flamingosPanel.activeSelf == true)
        {
            foreach (GameObject go in flamingos)
            {
                go.gameObject.GetComponent<AnimalScript>().Mollusc();
            }
        }

        if (giraffePanel.activeSelf == true)
        {
            foreach (GameObject go in giraffe)
            {
                go.gameObject.GetComponent<AnimalScript>().Mollusc();
            }
        }

        if (pinguinsPanel.activeSelf == true)
        {
            foreach (GameObject go in pinguins)
            {
                go.gameObject.GetComponent<AnimalScript>().Mollusc();
            }
        }

        if (octopusPanel.activeSelf == true)
        {
            foreach (GameObject go in octopus)
            {
                go.gameObject.GetComponent<AnimalScript>().Mollusc();
            }
        }

        if (turtlePanel.activeSelf == true)
        {
            foreach (GameObject go in turtle)
            {
                go.gameObject.GetComponent<AnimalScript>().Mollusc();
            }
        }

        if (fishPanel.activeSelf == true)
        {
            foreach (GameObject go in fish)
            {
                go.gameObject.GetComponent<AnimalScript>().Mollusc();
            }
        }
    }

    public void SeedFood()
    {
        if (racoonPanel.activeSelf == true)
        {
            foreach (GameObject go in racoons)
            {
                go.gameObject.GetComponent<AnimalScript>().Seed();
            }
        }

        if (crocodilePanel.activeSelf == true)
        {
            foreach (GameObject go in crocodile)
            {
                go.gameObject.GetComponent<AnimalScript>().Seed();
            }
        }

        if (flamingosPanel.activeSelf == true)
        {
            foreach (GameObject go in flamingos)
            {
                go.gameObject.GetComponent<AnimalScript>().Seed();
            }
        }

        if (giraffePanel.activeSelf == true)
        {
            foreach (GameObject go in giraffe)
            {
                go.gameObject.GetComponent<AnimalScript>().Seed();
            }
        }

        if (pinguinsPanel.activeSelf == true)
        {
            foreach (GameObject go in pinguins)
            {
                go.gameObject.GetComponent<AnimalScript>().Seed();
            }
        }

        if (octopusPanel.activeSelf == true)
        {
            foreach (GameObject go in octopus)
            {
                go.gameObject.GetComponent<AnimalScript>().Seed();
            }
        }

        if (turtlePanel.activeSelf == true)
        {
            foreach (GameObject go in turtle)
            {
                go.gameObject.GetComponent<AnimalScript>().Seed();
            }
        }

        if (fishPanel.activeSelf == true)
        {
            foreach (GameObject go in fish)
            {
                go.gameObject.GetComponent<AnimalScript>().Seed();
            }
        }
    }

    public void GrassFood()
    {
        if (racoonPanel.activeSelf == true)
        {
            foreach (GameObject go in racoons)
            {
                go.gameObject.GetComponent<AnimalScript>().Grass();
            }
        }

        if (crocodilePanel.activeSelf == true)
        {
            foreach (GameObject go in crocodile)
            {
                go.gameObject.GetComponent<AnimalScript>().Grass();
            }
        }

        if (flamingosPanel.activeSelf == true)
        {
            foreach (GameObject go in flamingos)
            {
                go.gameObject.GetComponent<AnimalScript>().Grass();
            }
        }

        if (giraffePanel.activeSelf == true)
        {
            foreach (GameObject go in giraffe)
            {
                go.gameObject.GetComponent<AnimalScript>().Grass();
            }
        }

        if (pinguinsPanel.activeSelf == true)
        {
            foreach (GameObject go in pinguins)
            {
                go.gameObject.GetComponent<AnimalScript>().Grass();
            }
        }

        if (octopusPanel.activeSelf == true)
        {
            foreach (GameObject go in octopus)
            {
                go.gameObject.GetComponent<AnimalScript>().Grass();
            }
        }

        if (turtlePanel.activeSelf == true)
        {
            foreach (GameObject go in turtle)
            {
                go.gameObject.GetComponent<AnimalScript>().Grass();
            }
        }

        if (fishPanel.activeSelf == true)
        {
            foreach (GameObject go in fish)
            {
                go.gameObject.GetComponent<AnimalScript>().Grass();
            }
        }
    }

    public void MeatFood()
    {
        if (racoonPanel.activeSelf == true)
        {
            foreach (GameObject go in racoons)
            {
                go.gameObject.GetComponent<AnimalScript>().Meat();
            }
        }

        if (crocodilePanel.activeSelf == true)
        {
            foreach (GameObject go in crocodile)
            {
                go.gameObject.GetComponent<AnimalScript>().Meat();
            }
        }

        if (flamingosPanel.activeSelf == true)
        {
            foreach (GameObject go in flamingos)
            {
                go.gameObject.GetComponent<AnimalScript>().Meat();
            }
        }

        if (giraffePanel.activeSelf == true)
        {
            foreach (GameObject go in giraffe)
            {
                go.gameObject.GetComponent<AnimalScript>().Meat();
            }
        }

        if (pinguinsPanel.activeSelf == true)
        {
            foreach (GameObject go in pinguins)
            {
                go.gameObject.GetComponent<AnimalScript>().Meat();
            }
        }

        if (octopusPanel.activeSelf == true)
        {
            foreach (GameObject go in octopus)
            {
                go.gameObject.GetComponent<AnimalScript>().Meat();
            }
        }

        if (turtlePanel.activeSelf == true)
        {
            foreach (GameObject go in turtle)
            {
                go.gameObject.GetComponent<AnimalScript>().Meat();
            }
        }

        if (fishPanel.activeSelf == true)
        {
            foreach (GameObject go in fish)
            {
                go.gameObject.GetComponent<AnimalScript>().Meat();
            }
        }
    }

    public void EverythingFood()
    {
        if (racoonPanel.activeSelf == true)
        {
            foreach (GameObject go in racoons)
            {
                go.gameObject.GetComponent<AnimalScript>().RandomFood();
            }
        }

        if (crocodilePanel.activeSelf == true)
        {
            foreach (GameObject go in crocodile)
            {
                go.gameObject.GetComponent<AnimalScript>().RandomFood();
            }
        }

        if (flamingosPanel.activeSelf == true)
        {
            foreach (GameObject go in flamingos)
            {
                go.gameObject.GetComponent<AnimalScript>().RandomFood();
            }
        }

        if (giraffePanel.activeSelf == true)
        {
            foreach (GameObject go in giraffe)
            {
                go.gameObject.GetComponent<AnimalScript>().RandomFood();
            }
        }

        if (pinguinsPanel.activeSelf == true)
        {
            foreach (GameObject go in pinguins)
            {
                go.gameObject.GetComponent<AnimalScript>().RandomFood();
            }
        }

        if (octopusPanel.activeSelf == true)
        {
            foreach (GameObject go in octopus)
            {
                go.gameObject.GetComponent<AnimalScript>().RandomFood();
            }
        }

        if (turtlePanel.activeSelf == true)
        {
            foreach (GameObject go in turtle)
            {
                go.gameObject.GetComponent<AnimalScript>().RandomFood();
            }
        }

        if (fishPanel.activeSelf == true)
        {
            foreach (GameObject go in fish)
            {
                go.gameObject.GetComponent<AnimalScript>().RandomFood();
            }
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static AnimalScript;

public class LandAnimal : AnimalVertebrate
{
    // Start is called before the first frame update
    void Start()
    {
        base.Start();
        habitat = Habitat.Land;
    }

    // Update is called once per frame
    void Update()
    {
        base.Update();
    }
}

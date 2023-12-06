using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OviparusHotBlooded : AnimalHotBlooded
{
    // Start is called before the first frame update
    protected override void Start()
    {
        reproduction = Reproduction.Oviparous;
        base.Start();
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
    }
}

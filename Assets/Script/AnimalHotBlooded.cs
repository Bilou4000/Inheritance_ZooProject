using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static AnimalScript;

public class AnimalHotBlooded : LandAnimal
{
    // Start is called before the first frame update
    protected override void Start()
    {
        blood = Blood.HotBlooded;
        base.Start();        
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
    }
}

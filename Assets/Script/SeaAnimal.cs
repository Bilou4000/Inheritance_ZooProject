using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeaAnimal : AnimalVertebrate
{

    // Start is called before the first frame update
    protected override void Start()
    {
        spriteRenderer.color = new Color(0/255f, 77/255f, 128/255f);
        base.Start();
        habitat = Habitat.Water;
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
    }

}

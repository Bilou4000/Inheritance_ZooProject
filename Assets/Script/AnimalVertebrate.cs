using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalVertebrate : AnimalScript
{
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        skeleton = Skeleton.Vertebrate;
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
    }
}

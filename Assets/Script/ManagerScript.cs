using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static AnimalScript;

public class ManagerScript : MonoBehaviour
{
    public static ManagerScript instance;
    public GameObject canva;

    private Vector3 mousePos;
    public GameObject theFood;

    void Start()
    {
        instance = this;
    }

    private void Update()
    {
        mousePos = Input.mousePosition;
        theFood.transform.position = mousePos;
    }

    public void Food(GameObject foodType)
    {
        theFood = Instantiate(foodType, mousePos, Quaternion.identity);
        theFood.transform.SetParent(canva.transform, true);
        theFood.transform.SetSiblingIndex(0);
    }
}

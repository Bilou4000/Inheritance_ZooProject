using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerScript : MonoBehaviour
{
    public GameObject fish;
    public GameObject mollusc;
    public GameObject seed;
    public GameObject grass;
    public GameObject meat;
    public GameObject water;

    public GameObject canva;

    private Vector3 mousePos;
    private GameObject food;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void Update()
    {
        mousePos = Input.mousePosition;
        food.transform.position = mousePos;
    }

    public void Food(GameObject foodType)
    {
        food = Instantiate(foodType, mousePos, Quaternion.identity);
        food.transform.SetParent(canva.transform, true);
        food.transform.SetSiblingIndex(0);
    }

}

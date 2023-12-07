using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using static AnimalScript;

[Serializable]
public class AnimalInfo
{
    public List<AnimalSave> animals = new List<AnimalSave>();
}

[Serializable]
public struct AnimalSave
{
    public string nameAnimal;
    public float age;
    public float hunger, thirst, tiredness;
    public float x, y, z;

    public StateOfAnimal state;
    public TypeOfFood food;
}

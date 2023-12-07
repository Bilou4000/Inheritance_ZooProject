using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using static AnimalScript;

[Serializable]
public class AnimalInfo
{
    //public float hunger, thirst, tiredness;
    public List<AnimalSave> animals = new List<AnimalSave>();
}

[Serializable]
public struct AnimalSave
{
    public string name;
    public float hunger;
    public float thirst;
    public float tiredness;

    public State state;
    public TypeOfFood food;
}

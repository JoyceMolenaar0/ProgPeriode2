using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Bird : Animal
{
    public override void Move()
    {
        Debug.Log("Flaps It's Wings");
    }
}

public class Dog : Animal
{
    public override void Move()
    {
        Debug.Log("Walks Cutely");
    }
}

public class Elephant : Animal
{
    public override void Move()
    {
        Debug.Log("Takes Big Steps");
    }
}

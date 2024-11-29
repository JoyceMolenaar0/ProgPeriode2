using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoo : MonoBehaviour
{
    private void Start()
    {
        List<Animal> Animals = new List<Animal>
        {
            new Bird(),
            new Dog(),
            new Elephant()
        };

        foreach (Animal animals in Animals)
        {
            animals.Eat();
            animals.Move();
        }

    }
}

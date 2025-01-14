using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elf : Unit, IMovable, IDamagable
{
    [SerializeField] GameObject theBody;
    private float theTime;
    private bool isActive = true;
    private void Update()
    {
        Move();

        theTime += Time.deltaTime;

        if (theTime > 2)
        {
            isActive = !isActive;
            theTime = 0;
        }

        if (!isActive)
        {
            makeInactive();
        }
        else if (isActive)
        {
            makeActive();
        }
    }

    private void makeInactive()
    {
        theBody.SetActive(false);
    }

    private void makeActive()
    {
        theBody.SetActive(true);
    }
}

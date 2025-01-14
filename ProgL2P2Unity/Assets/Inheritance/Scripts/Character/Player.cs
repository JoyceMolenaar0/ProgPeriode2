using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Unit, IMovable, IDamagable
{
    public override void Move()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        transform.position += transform.forward * moveSpeed * Time.deltaTime * vertical;
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime * horizontal);
    }
}

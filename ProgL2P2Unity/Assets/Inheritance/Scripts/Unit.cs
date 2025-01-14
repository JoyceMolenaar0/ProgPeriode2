using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class Unit : MonoBehaviour, IMovable, IDamagable
{
    public int health { get; private set; } = 100;

    public float moveSpeed = 10;
    public float rotationSpeed = 10;

    private void Update()
    {
        Move();
    }
    public virtual void Move()
    {
        transform.position += transform.forward * moveSpeed * Time.deltaTime;
    }
    public virtual void TakeDamage()
    {
        health -= 10;
        if (health <= 0)
        {
            Die();
        }
    }
    protected void Die()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            TakeDamage();
        }

        if (other.CompareTag("Border"))
        {
            transform.rotation = transform.rotation * Quaternion.Euler(0, 180, 0);
            Debug.Log("Hit the border");
        }
    }
}


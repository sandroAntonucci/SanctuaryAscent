using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerOrb : MonoBehaviour
{

    public int powerQuant;

    public FloatingMovement floatingMovement;

    public Vector2 playerPosition;

    public bool playerInRange = false;

    public void Update()
    {
        if (playerInRange)
        {
            floatingMovement.enabled = false;
            playerPosition = GameObject.FindWithTag("Player").transform.position;
            transform.position = Vector2.MoveTowards(transform.position, playerPosition, 0.05f);
        }

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            collision.collider.GetComponent<Player>().AddPower(powerQuant);
            Destroy(gameObject);
        }
    }
}


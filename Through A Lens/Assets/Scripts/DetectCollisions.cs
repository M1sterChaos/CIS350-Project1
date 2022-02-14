using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// attach to money
public class DetectCollisions : MonoBehaviour
{
    public GameObject money;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // If the player enters money hitbox,
        // add one to the current score and "delete"
        // the money object
        if (collision.CompareTag("Player"))
        {
            DisplayScore.score++;
            money.SetActive(false);
        }
    }
}
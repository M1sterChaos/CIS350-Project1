//Evan Wieland
//Project 1
//Progresses tutorial

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialTrigger : MonoBehaviour
{
    private bool entered = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // If the player enters money hitbox,
        // add one to the current score and "delete"
        // the money object
        if (collision.CompareTag("Player") && !entered)
        {
            Tutorial.step++;
            entered = true;
        }

        if (collision.CompareTag("Projectile") && !entered && Tutorial.step == 9)
        {
            Tutorial.step++;
            entered = true;
        }
    }
}
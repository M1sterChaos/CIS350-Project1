using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    //private bool triggered = false;
    public GameObject money;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") /*&& !triggered*/)
        {
            //triggered = true;
            DisplayScore.score++;
            money.SetActive(false);
        }

        //DisplayScore.score++;
        //Destroy(collision.gameObject);
    }
}
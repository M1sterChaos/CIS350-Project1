/*
 * Austin Buck
 * Project 3
 * Controls health bar at the bottom of the screen
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthBehavior : MonoBehaviour
{
    public GameObject[] fullHealth;
    public GameObject[] emptyHealth;

    public int healthleft;

    private void Start()
    {
        healthleft = fullHealth.Length - 1;
        fullHealth[0].SetActive(true);
        fullHealth[1].SetActive(true);
        fullHealth[2].SetActive(true);

        emptyHealth[0].SetActive(false);
        emptyHealth[1].SetActive(false);
        emptyHealth[2].SetActive(false);
    }

    public void loseHealth()
    {
        if(healthleft >= 0)
        {
            fullHealth[healthleft].SetActive(false);
            emptyHealth[healthleft].SetActive(true);

            healthleft--;
        }

    }
}

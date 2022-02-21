/*
 * Evan Wieland
 * Project 1
 * Controls the tut
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tut : MonoBehaviour
{
    int tut = 0;

    public GameObject gameObj;

    public static bool tutViewed = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown || tutViewed)
        {
            tutViewed = true;
            gameObj.SetActive(false);
        }
    }
}

//Evan Wieland
//Project 1
//Progresses tutorial

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tut : MonoBehaviour
{
    int tut = 0;

    public Text t0;
    public Text t1;
    public Text t2;
    public GameObject gameObj;


    static public bool tutViewed = false;


    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            tut++;
        }

        t0.enabled = tut == 0;
        t1.enabled = tut == 1;
        gameObject.SetActive(tut <= 1);
        tutViewed = tut > 1;
    }
}
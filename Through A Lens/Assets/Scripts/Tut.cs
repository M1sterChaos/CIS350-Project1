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

    public Canvas tutorial;
    public Text t0;
    public Text t1;
    public Text t2;
    public Image bg;
    //public GameObject gameObj;

    public static bool tutViewed = false;

    private void Start()
    {
        tutorial = GameObject.FindGameObjectWithTag("Tutorial").GetComponent<Canvas>();
        if (tutViewed == false)
        {
            tutorial.enabled = true;
        }
        
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            tut++;
        }

        bg.enabled = true;
        t2.enabled = true;
        t0.enabled = (tut == 0);
        t1.enabled = (tut == 1);

        if(tut > 1)
        {
            tutViewed = true;
            tutorial.enabled = false;
        }
    }
}
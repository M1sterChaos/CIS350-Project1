/*
 * Zach Daly
 * Project 1+2
 * Display winning text upon victory
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// Attach to goal
public class WinScript : MonoBehaviour
{
    public Canvas vicTextCanvas;
    private int win = 0;
    private bool complete = false;

    private void Start()
    {
        //displayScoreScript = GameObject.FindGameObjectWithTag("ScoreManager").GetComponent<DisplayScore>();

        vicTextCanvas = GameObject.FindGameObjectWithTag("VictoryMsg").GetComponent<Canvas>();
        vicTextCanvas.enabled = false;

        complete = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && complete)
        {
            vicTextCanvas.enabled = false;

            if(PlatformGenerator.level < 2)
            {
                PlatformGenerator.level++;
                SceneManager.LoadScene("AustinTestScene");
            }
            else if(PlatformGenerator.level >= 2)
            {
                SceneManager.LoadScene("ZachMadeScene");
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            complete = true;
            vicTextCanvas.enabled = true;
        }
    }

}
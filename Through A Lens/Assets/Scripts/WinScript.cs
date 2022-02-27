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

    public PlatformGenerator pg;
    public BoxCollider2D bc;

    private void Start()
    {
        //displayScoreScript = GameObject.FindGameObjectWithTag("ScoreManager").GetComponent<DisplayScore>();

        vicTextCanvas = GameObject.FindGameObjectWithTag("VictoryMsg").GetComponent<Canvas>();
        vicTextCanvas.enabled = false;

        complete = false;

        pg = GameObject.FindGameObjectWithTag("GameController").GetComponent<PlatformGenerator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && complete)
        {
            vicTextCanvas.enabled = false;
            if (win <= 0)
            {
                GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(0, 3, 0);

                pg.levelGen(1);
            }
            else if( win == 1 )
            {
                GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(0, 3, 0);
                pg.levelGen(2);
            }
            else if (win == 2)
            {
                GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(0, 3, 0);
                pg.levelGen(3);
            }
            else
            {
                pg.dataReset();
                SceneManager.LoadScene("ZachMadeLevel");
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
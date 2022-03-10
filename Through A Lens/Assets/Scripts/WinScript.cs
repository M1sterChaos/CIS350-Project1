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

    public static int levelscompleted = 0;

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

            levelscompleted++;

            Debug.Log(levelscompleted);
            
            if(levelscompleted <= 0)
            {
                levelscompleted = -1;
                SceneManager.LoadScene("Tutorial");
            }
            
            else if (levelscompleted == 1)
            {
                SceneManager.LoadScene("LukeLevel1");
            }
            
            else if (levelscompleted <= 2)
            {
                SceneManager.LoadScene("LukeLevel2");
            }
            
            else if (levelscompleted == 3)
            {
                SceneManager.LoadScene("ZachLevel1");
            }
            
            if (levelscompleted == 4)
            {
                SceneManager.LoadScene("ZachLevel2");
            }

            else if (levelscompleted >= 5)
            {
                SceneManager.LoadScene("EndScreen");
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
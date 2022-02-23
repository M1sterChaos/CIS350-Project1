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
    public Text victoryText;
    public Image vicBG;

    private void Update()
    {
        //Press R to restart if game is over
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //DisplayScore.gameOver = true;
        victoryText.gameObject.SetActive(true);
        vicBG.gameObject.SetActive(true);
    }
}
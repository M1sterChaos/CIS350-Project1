/*
 * Zach Daly
 * Project 1+2
 * Controls scoring display
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DisplayScore : MonoBehaviour
{
    public Text scoreText;
    public Text victoryText;
    public static int score;
    public bool gameOver;
    public GameObject finish;
    //public PlatformGenerator pg;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        gameOver = false;
        scoreText.text = "Score: 0";
        //pg = gameObject.GetComponent<PlatformGenerator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Show score while game isnt over
        if (!gameOver)
            scoreText.text = "Score: " + score;

        // Open finish when all money is collected
        if (score >= 3 && !gameOver)
        {
            finish.SetActive(true);
            //Instantiate(finish, new Vector3(pg.xval, pg.yval + 2.0f, 0.0f), Quaternion.identity);
        }
    }
}
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
    public /*static*/ bool gameOver;
    public GameObject finish;
    public PlatformGenerator pg;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        gameOver = false;

        scoreText.text = "Score: 0";

        finish.SetActive(false) ;

        pg = gameObject.GetComponent<PlatformGenerator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Show score while game isnt over
        if (!gameOver)
            scoreText.text = "Score: " + score;

        // Open finish when all money is collected
        if (score >= 3)
        {
            Instantiate(finish, new Vector3(pg.xval, pg.yval + 2.0f, 0.0f), Quaternion.identity);
            finish.SetActive(true);
        }

        // Show win message when player hits goal (WORK IN PROGRESS)
    /*
        if (gameOver)
        {
            //might have to change what textbox this is
            victoryText.enabled = true;

            if (Input.GetKeyDown(KeyCode.R))
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    */
    }
}
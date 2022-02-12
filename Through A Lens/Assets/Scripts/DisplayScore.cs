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
    public static bool gameOver;
    public GameObject finish;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        gameOver = false;

        //scoreText = GetComponent<Text>();
        scoreText.text = "Score: 0";
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
            finish.SetActive(true);
        }

        // Show end msg depending on score
        if (gameOver)
        {
                //might have to change what textbox this is
            victoryText.text = "You win";

            if (Input.GetKeyDown(KeyCode.R))
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinScript : MonoBehaviour
{
    //public Text victoryText;

    private void Update()
    {
        /*
        if (DisplayScore.gameOver)
        {
            if (DisplayScore.won)
                //might have to change what textbox this is
                victoryText.text = "You win";
            else
                victoryText.text = "You lose";

            if (Input.GetKeyDown(KeyCode.R))
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        */
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (DisplayScore.score >= 3)
        {
            DisplayScore.gameOver = true;
        }
    }
}

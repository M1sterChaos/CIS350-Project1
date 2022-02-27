/* 
 * Zach Daly
 * Project 1+2
 * Causes the player to lose upon falling off
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// attach to player
public class LoseOnFall : MonoBehaviour
{
    public Canvas loseScreen;
    public static bool gameOver;
    public static bool won = false;

    private void Start()
    {
        loseScreen = GameObject.FindGameObjectWithTag("FailMsg").GetComponent<Canvas>();
        loseScreen.enabled = false;
    }


    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -5)
        {
            gameOver = true;
            loseScreen.enabled = true;

            // press R to restart
            if (Input.GetKeyDown(KeyCode.R))
            {
                GameObject.FindGameObjectWithTag("Player").transform.SetPositionAndRotation(new Vector3(0, 1, 0), Quaternion.identity);
                loseScreen.enabled = false;
            }
        }
    }
}
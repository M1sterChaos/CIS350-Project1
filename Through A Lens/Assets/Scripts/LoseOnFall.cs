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
    public Camera cam;

    public Canvas loseScreen;
    public static bool gameOver;
    public static bool won = false;
    public static bool safePlay = false;

    private void Start()
    {
        loseScreen = GameObject.FindGameObjectWithTag("FailMsg").GetComponent<Canvas>();
        loseScreen.enabled = false;
    }


    // Update is called once per frame
    void Update()
    {
        

        if (transform.position.y < -20)
        {
            // press R to restart
            if (Input.GetKeyDown(KeyCode.R) || safePlay)
            {
                gameOver = false;
                GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(0, 3, 0);
                loseScreen.enabled = false;
                GameObject.FindGameObjectWithTag("MainCamera").transform.position = GameObject.FindGameObjectWithTag("Player").transform.position + new Vector3(0, 0, -15);
            }else{
                gameOver = true;
                loseScreen.enabled = true;
            }
        }
    }
}
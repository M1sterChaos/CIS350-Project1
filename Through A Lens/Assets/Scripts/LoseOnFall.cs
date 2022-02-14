using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// attach to player
public class LoseOnFall : MonoBehaviour
{
    public GameObject gameOverText;
    public static bool gameOver;
    public static bool won = false;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -5)
        {
            gameOver = true;
            gameOverText.SetActive(true);

            // press R to restart
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                ColorChanger.reset();
            }
        }
    }
}

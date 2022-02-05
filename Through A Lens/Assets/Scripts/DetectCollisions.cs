using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private DisplayScore displayScoreScript;

    // Start is called before the first frame update
    void Start()
    {
        displayScoreScript = GameObject.FindGameObjectWithTag("DisplayScoreText").GetComponent<DisplayScore>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        displayScoreScript.score++;
        Destroy(collision.gameObject);
    }
}

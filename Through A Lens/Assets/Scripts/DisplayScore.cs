using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DisplayScore : MonoBehaviour
{
    public Text textbox;
    public int score;
    public GameObject finish;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;

        textbox = GetComponent<Text>();
        textbox.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        textbox.text = "Score: " + score;

        if (score >= 3)
        {
            finish.SetActive(true);
        }
    }
}
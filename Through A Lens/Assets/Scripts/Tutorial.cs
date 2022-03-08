//Evan Wieland
//Project 1
//Progresses tutorial

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{
    int step = 0;

    private Canvas canvas;
    public GameObject bg;
    public GameObject colorWheel;
    public GameObject health;
    public GameObject score;
    public GameObject goal;
    public List<Text> tutorialSteps = new List<Text>();

    private void Start()
    {
        canvas = GetComponent<Canvas>();
        
        PlayerBehavior.allowJump = false;
        PlayerBehavior.allowMove = false;
        ColorChanger.allowColorChange = false;
        ShootPrefab.allowShoot = false;
        
        goal.SetActive(false);
        score.SetActive(false);
        colorWheel.SetActive(false);
        health.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        tutorialSteps.ForEach(tStep => tStep.enabled = false);

        if(step == 0) {
            tutorialSteps[0].enabled = true;
            if (Input.anyKeyDown) step++;
        }

        if(step == 1) {
            tutorialSteps[1].enabled = true;
            PlayerBehavior.allowMove = true;
            if (Input.GetKeyDown(KeyCode.A)||Input.GetKeyDown(KeyCode.D)) step++;
        }
        
        if(step == 2) {
            tutorialSteps[2].enabled = true;
            PlayerBehavior.allowJump = true;
            if (Input.GetKeyDown(KeyCode.W)) step++;
        }

        if(step == 3) {
            tutorialSteps[3].enabled = true;
            if (Input.anyKeyDown) step++;
        }     

        if(step == 4) {
            tutorialSteps[4].enabled = true;
            ColorChanger.allowColorChange = true;
            colorWheel.SetActive(true);
            if (Input.GetKeyDown(KeyCode.UpArrow)||Input.GetKeyDown(KeyCode.RightArrow)||Input.GetKeyDown(KeyCode.DownArrow)||Input.GetKeyDown(KeyCode.LeftArrow)) step++;
        }   
    }
}
//Evan Wieland
//Project 1
//Progresses tutorial

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{
    public static int step = 0;

    private Canvas canvas;
    public GameObject bg;
    public GameObject colorWheel;
    public GameObject health;
    public GameObject score;
    public GameObject goal;
    public List<Text> tutorialSteps = new List<Text>();
    public List<GameObject> tutorialSections = new List<GameObject>();

    private void Start()
    {
        canvas = GetComponent<Canvas>();
        
        PlayerBehavior.allowJump = false;
        PlayerBehavior.allowMove = false;
        ColorChanger.allowColorChange = false;
        ShootPrefab.allowShoot = false;
        LoseOnFall.safePlay = true;
        
        goal.SetActive(false);
        score.SetActive(false);
        colorWheel.SetActive(false);
        health.SetActive(false);

        tutorialSections.ForEach(tSection => tSection.SetActive(false));
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
            if (Input.GetKeyUp(KeyCode.A)||Input.GetKeyUp(KeyCode.D)) step++;
        }
        
        if(step == 2) {
            tutorialSteps[2].enabled = true;
            PlayerBehavior.allowJump = true;
            if (Input.GetKeyUp(KeyCode.W)) step++;
        }

        if(step == 3) {
            tutorialSteps[3].enabled = true;
            if (Input.anyKeyDown) step++;
        }     

        if(step == 4) {
            tutorialSteps[4].enabled = true;
            ColorChanger.allowColorChange = true;
            colorWheel.SetActive(true);
            if (Input.GetKeyUp(KeyCode.UpArrow)||Input.GetKeyUp(KeyCode.RightArrow)||Input.GetKeyUp(KeyCode.DownArrow)||Input.GetKeyUp(KeyCode.LeftArrow)) step++;
        }

        if(step == 5) {
            tutorialSteps[5].enabled = true;
            tutorialSections[0].SetActive(true);
            colorWheel.SetActive(true);
        }   

        if(step == 6) {
            tutorialSteps[6].enabled = true;
            tutorialSections[1].SetActive(true);
        }

        if(step == 7) {
            tutorialSteps[7].enabled = true;
            tutorialSections[2].SetActive(true);
            score.SetActive(true);
        }

        if(step == 8) {
            tutorialSteps[8].enabled = true;
            tutorialSections[3].SetActive(true);
            if (Input.anyKeyDown) step++;
        }

        if(step == 9) {
            tutorialSteps[9].enabled = true;
            health.SetActive(true);
            ShootPrefab.allowShoot = true;
        }

        if(step == 10) {
            tutorialSteps[10].enabled = true;
            tutorialSections[4].SetActive(true);
            goal.SetActive(true);
        }

        if(step == 11) {
            canvas.enabled = false;
            LoseOnFall.safePlay = false;
        }
    }
}
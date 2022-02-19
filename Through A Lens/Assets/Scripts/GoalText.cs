/*
 * Austin Buck
 * Project 2
 * Controls goal text
 */
using UnityEngine;
using UnityEngine.UI;

public class GoalText : MonoBehaviour
{
    public Text goalText;

    public int moneyLeft;

    // Update is called once per frame
    void Update()
    {
        goalText.text = "Collect all the money and get to the end. \nMoney left: " + moneyLeft;

        if (moneyLeft <= 0)
        {
            goalText.text = "You have collected all the money! \nNow get to the end to win!";
        }
    }
}

/*
 * Zach Daly, Austin Buck
 * Project 1 + 2
 * Destroys money as it collides with player and how much money is left
 */
using UnityEngine;

// attach to money
public class DetectCollisions : MonoBehaviour
{
    public GameObject money;
    private GoalText GTM;

    private void Start()
    {
        GTM = GameObject.FindGameObjectWithTag("GTM").GetComponent<GoalText>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // If the player enters money hitbox,
        // add one to the current score and "delete"
        // the money object
        if (collision.CompareTag("Player"))
        {
            GTM.moneyLeft--;
            DisplayScore.score++;
            Destroy(money);
        }
    }
}
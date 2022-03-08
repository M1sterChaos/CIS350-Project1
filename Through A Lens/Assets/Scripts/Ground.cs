/*
 * Evan Wieland
 * Project 1
 * Controls ground collision
 */

using UnityEngine;

public class Ground : MonoBehaviour
{
    public string color;
    public BoxCollider2D _bc;
    public bool neutral;

    public GameObject enemy;
    private Random random = new Random();


    // Start is called before the first frame update
    void Start()
    {

       if(enemy){
        // 50% chance enemy will spawn on plat 
        bool chance = (Random.Range(0, 2) == 0);
        enemy.SetActive(chance);
       }
      
       _bc = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _bc.enabled = ((ColorChanger.colorText == color || neutral) && !LoseOnFall.gameOver);
    }
}

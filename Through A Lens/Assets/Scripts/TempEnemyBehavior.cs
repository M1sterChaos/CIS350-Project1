/* Austin Buck, Luke Lesimple
 * Project 1
 * Controls enemy spawn and behavior
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempEnemyBehavior : MonoBehaviour
{
    public string color;
    private BoxCollider2D bc;
    public Sprite[] enemycolors = new Sprite[4];
    public SpriteRenderer sp;
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        //This is supposed to choose a random sprite and spawn it on a grey platform I made just for testing, however it does not and I don't
        //know why and its 3AM so i'm gonna put this off.
        sp = gameObject.GetComponent<SpriteRenderer>();
        sp.sprite = enemycolors[Random.Range(0,3)];
        Instantiate(enemy, new Vector3(18, 8, 0.0f), Quaternion.identity);

        bc = GetComponent<BoxCollider2D>();

    }

    // Update is called once per frame
    void Update()
    {
        bc.enabled = ColorChanger.colorText == color;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(ColorChanger.colorText == color)
        {
            Destroy(this);
        }
    }
}

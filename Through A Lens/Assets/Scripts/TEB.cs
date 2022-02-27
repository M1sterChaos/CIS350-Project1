/* Austin Buck
 * Project 1
 * Test enemy behavior script
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TEB : MonoBehaviour
{
    private BoxCollider2D bc;
    public Sprite[] enemycolors = new Sprite[4];
    private SpriteRenderer sp;

    // Start is called before the first frame update
    void Start()
    {
        sp = this.gameObject.GetComponent<SpriteRenderer>();
        sp.sprite = enemycolors[Random.Range(0,4)];
        bc = GetComponent<BoxCollider2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Projectile")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}

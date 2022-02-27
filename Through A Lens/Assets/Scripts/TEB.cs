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
    public Canvas loseScreen;
    private BoxCollider2D bc;
    public Sprite[] enemycolors = new Sprite[4];
    private SpriteRenderer sp;
    private bool hit = false;

    // Start is called before the first frame update
    void Start()
    {
        sp = this.gameObject.GetComponent<SpriteRenderer>();
        sp.sprite = enemycolors[Random.Range(0,4)];
        bc = GetComponent<BoxCollider2D>();

        loseScreen = GameObject.FindGameObjectWithTag("FailMsg").GetComponent<Canvas>();
        loseScreen.enabled = false;
    }

    private void Update()
    {
        if(hit && Input.GetKeyDown(KeyCode.R))
        {
            GameObject.FindGameObjectWithTag("Player").transform.SetPositionAndRotation(new Vector3(0, 1, 0), Quaternion.identity);
            loseScreen.enabled = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            hit = true;
            loseScreen.enabled = true;
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

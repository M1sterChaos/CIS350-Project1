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

    private healthBehavior hb;
    public GameObject target1;
    public GameObject target2;
    bool firstTarget = false;

    // Start is called before the first frame update
    void Start()
    {
        hb = GameObject.FindGameObjectWithTag("HB").GetComponent<healthBehavior>();
        sp = this.gameObject.GetComponent<SpriteRenderer>();
        sp.sprite = enemycolors[Random.Range(0,4)];
        bc = GetComponent<BoxCollider2D>();

        loseScreen = GameObject.FindGameObjectWithTag("FailMsg").GetComponent<Canvas>();
        loseScreen.enabled = false;
    }

    private void Update()
    {
        MoveOnPlatform();
        if(hit && Input.GetKeyDown(KeyCode.R))
        {
            GameObject.FindGameObjectWithTag("Player").transform.SetPositionAndRotation(new Vector3(0, 1, 0), Quaternion.identity);
            loseScreen.enabled = false;
            hit = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            hit = true;
            hb.loseHealth();
            if(hb.healthleft < 0)
            {
                LoseOnFall.gameOver = true;
                loseScreen.enabled = true;
            }

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Projectile")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        if(collision.gameObject.tag == "target")
        {
            firstTarget = !firstTarget;
        }
    }
    public void MoveOnPlatform()
    {

        if(firstTarget)
        {
            transform.position = Vector3.MoveTowards(transform.position, target1.transform.position, 1f * Time.deltaTime);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, target2.transform.position, 1f * Time.deltaTime);
        }
    }
}

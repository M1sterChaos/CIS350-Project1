using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempEnemyBehavior : MonoBehaviour
{
    public string color;
    private BoxCollider2D bc;

    // Start is called before the first frame update
    void Start()
    {
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

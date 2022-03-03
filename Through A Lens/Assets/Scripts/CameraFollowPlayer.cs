/*
 * Luke Lesimple
 * Project 1
 * Camera follows Player
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    public GameObject Player;
    private float leftx;
    private float rightx;
    private float topy;
    private float bottomy;

    private float x;
    private float y;

    private void Start()
    {
        leftx = -26.0f;
        rightx = 243.0f;
        topy = 57.0f;
        bottomy = -23.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x >= rightx)
        {
            x = rightx;
        }
        else if(transform.position.x <= leftx)
        {
            x = leftx;
        }
        else
        {
            x = Player.transform.position.x;
        }

        if(transform.position.y >= topy)
        {
            y = topy;
        }
        else if (transform.position.y <=bottomy)
        {
            y = bottomy;
        }
        else
        {
            y = Player.transform.position.y;
            
        }

        transform.position = new Vector3(x, y, -15.0f);
        

        
    }
}

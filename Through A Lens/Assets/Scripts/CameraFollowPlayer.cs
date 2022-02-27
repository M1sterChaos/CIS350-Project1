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
    private Vector3 offset = new Vector3(0, 0, -15);

    // Update is called once per frame
    void Update()
    {
        transform.position = Player.transform.position + offset;
    }
}

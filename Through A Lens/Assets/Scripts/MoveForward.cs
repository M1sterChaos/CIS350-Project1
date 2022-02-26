/*
 * Evan Wieland, Zach Daly
 * Project 2
 * Manages forward movement.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 40;
    private float rightLimit = 999;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);

        if (transform.position.x > rightLimit)
            Destroy(gameObject);
    }
}
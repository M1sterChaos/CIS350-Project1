/*
 * Evan Wieland
 * Prototype 2
 * 
 * Destroys out of bounds objects.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Add script to the food and animal prefabs
public class DestroyOutOfBounds : MonoBehaviour
{
    public float rightBound = 100;

    private void Update()
    {
        // Seperating the food from the animals going out of bounds

        // Food
        if (transform.position.z > rightBound)
        {
            Destroy(gameObject);
        }
    }
}
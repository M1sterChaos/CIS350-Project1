/*
 * Evan Wieland
 * Project 1
 * 
 * Shoots a prefab.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPrefab : MonoBehaviour
{
    public GameObject prefabToShoot;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) /*&& Tut.tutViewed*/)
        {
            GameObject go = Instantiate(prefabToShoot, transform.position, prefabToShoot.transform.rotation);
            Destroy (go, 3.0f);
        }
    }
}
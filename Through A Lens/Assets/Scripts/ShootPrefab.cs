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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject projectile = Instantiate(prefabToShoot, transform.position, Quaternion.identity);
            Rigidbody2D projectileRB = projectile.GetComponent<Rigidbody2D>();
 
            projectileRB.velocity = PlayerBehavior.playerFlipX ? new Vector2(-50f, 1f): new Vector2(0f, 1f);
            Destroy(projectile, 3f);
        }
    }
}
/* Luke Lesimple
 * Through a lens
 * game ending hitbox
 */

//ONLY USE ON LAST LEVEL, NO CONDITIONS REQUIRED
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamedone : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("EndScreen");
        }
    }
}

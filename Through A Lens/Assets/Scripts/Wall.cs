/*
 * Luke Lesimple
 * Project 1
 * Controls wall collision
 */

using UnityEngine;

public class Wall : MonoBehaviour
{
    public string color;
    public BoxCollider2D _bc;

    public GameObject enemy;
    private Random random = new Random();


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        _bc.enabled = (ColorChanger._colorText == color);
    }
}

/*
 * Austin Buck
 * Project 1
 * Controls player movement
 */
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    //Speed and jump speed
    [SerializeField]
    private int speed;
    [SerializeField]
    private int jumpSpeed;

    //Variables
    private Rigidbody2D rb;
    private bool canJump = true;
    private float xinput;

    //Decting floor
    private LayerMask mask;

    //Vectors to move and jump
    private Vector2 move;
    private Vector2 jump;

    // Prevent user input right after tut
    private float _elapsedTime = 0;

    // Sets the intial jump vector, grabs layer mask, and grabs rigidbody
    void Start()
    {
        jump = new Vector2(0, jumpSpeed);
        rb = GetComponent<Rigidbody2D>();

        mask = LayerMask.GetMask("Floor");
    }

    // Allows the player to move, sets a raycast pointing down that checks for if you
    // land on the floor, and sees if you can jump
    void Update()
    {
        // Stop all play behavior if the tut is not finished
        if (Tut.tutViewed && _elapsedTime < 0.1)
        {
            _elapsedTime += Time.deltaTime;
            return;
        }

        PlayerMove();

        if(Physics2D.Raycast(transform.position, -transform.up, 1.1f, mask))
        {
            Debug.Log("gets to end");
            canJump = true;
        }

        if(Input.GetKeyDown(KeyCode.Space) && canJump == true)
        {
            PlayerJump();
        }
    }

    //Moves the player along the x axis by grabbing the axis and setting that in a vector
    private void PlayerMove()
    {
        xinput = Input.GetAxis("Horizontal");
        move = new Vector2(xinput * Time.deltaTime * speed, 0f * Time.deltaTime);

        this.transform.Translate(move, Space.World);
    }
    //Allows the player to jump by adding force to the rigidbody making the player go up
    private void PlayerJump()
    {
        canJump = false;
        rb.AddForce(jump * Vector2.up, ForceMode2D.Impulse);
    }
}

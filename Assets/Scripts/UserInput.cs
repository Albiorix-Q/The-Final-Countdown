using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour
{
    public Rigidbody2D rb;

    public float movementSpeed = 500f;
    public float maxMovementSpeed = 5;
    float movement = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal") * movementSpeed;
    }

    void FixedUpdate()
    {
        //if (Input.GetKey("a"))
        //{
        //    //rb.AddForce(new Vector2(-movementSpeed * Time.deltaTime, 0), ForceMode2D.Impulse);
        //    rb.velocity = new Vector2(-movementSpeed, rb.velocity.y);
        //}
        //if (Input.GetKey("d"))
        //{
        //    //rb.AddForce(new Vector2(movementSpeed * Time.deltaTime, 0), ForceMode2D.Impulse);
        //    rb.velocity = new Vector2(movementSpeed, rb.velocity.y);
        //}
        //rb.velocity = new Vector2(Mathf.Clamp(rb.velocity.x, -maxMovementSpeed, maxMovementSpeed), rb.velocity.y);

        rb.velocity = new Vector2(movement, rb.velocity.y);
    }
}

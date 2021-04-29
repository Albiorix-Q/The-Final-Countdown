using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour
{
    public Rigidbody2D rb;

    public float movementSpeed = 500f;
    public float jumpSpeed = 1000f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("a"))
        {
            rb.AddForce(new Vector2(-movementSpeed * Time.deltaTime, 0));
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(new Vector2(movementSpeed * Time.deltaTime, 0));
        }
        if (Input.GetKey("w"))
        {
            rb.AddForce(new Vector2(0, jumpSpeed * Time.deltaTime));
        }
    }
}

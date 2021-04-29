using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    public float jumpSpeed = 1000;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Jumpable")
        {
            rb.AddForce(new Vector2(0, jumpSpeed));
            Debug.Log("jump");
        }
        if (collision.collider.tag == "Respawn")
        {
            Debug.Log("die");

            gameObject.SetActive(false);
        }
    }
}

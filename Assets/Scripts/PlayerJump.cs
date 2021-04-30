using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    public GameObject gameOver;
    public float jumpSpeed = 1000;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Jumpable" && collision.relativeVelocity.y >= 0)
        {
            //rb.AddForce(new Vector2(0, jumpSpeed));
            rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
            Debug.Log("jump");
        }
        if (collision.collider.tag == "Respawn")
        {
            Debug.Log("die");
            gameOver.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}

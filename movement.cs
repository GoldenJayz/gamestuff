using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed = 100f;
    public float jumpheight;
    public bool inair = false;


    private Rigidbody2D rb;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        inair = false;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        inair = true;
    }
   
    void FixedUpdate()
    {
        Vector2 NoMovement = new Vector2(0f, 0f);

        float moveHorizontal = Input.GetAxis("Horizontal");

        if (moveHorizontal > 0)
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
        }
        if (moveHorizontal < 0)
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(new Vector2(0, jumpheight), ForceMode2D.Impulse);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sensor : MonoBehaviour
{
    public float playerSpeed;
    public Vector2 jumpHeight;

    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Hit detected");
        GetComponent<Rigidbody2D>().AddForce(jumpHeight, ForceMode2D.Impulse);
    }
}
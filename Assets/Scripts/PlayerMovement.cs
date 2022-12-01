using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate() // FIX!
    {
        float xMove = Input.GetAxisRaw("Horizontal");
        float zMove = Input.GetAxisRaw("Vertical");

        rb.velocity = new Vector3(xMove, 0, zMove) * speed + new Vector3(0, rb.velocity.y, 0); // FiX!
    }
}

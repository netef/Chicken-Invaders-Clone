using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    private float xMovement;
    private float yMovement;
    private Vector2 movement;
    private Vector3 mousePosition;
    private bool mouse = false;
    

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        mousePosition = Vector3.zero;
    }

    void Update()
    {
        xMovement = Input.GetAxisRaw("Horizontal");
        yMovement = Input.GetAxisRaw("Vertical");
        movement = new Vector2(xMovement, yMovement);
        if (mousePosition != Camera.main.ScreenToWorldPoint(Input.mousePosition))
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mouse = true;
        }

    }

    private void FixedUpdate()
    {
        if (mouse)
        {
            mouse = false;
            rb.MovePosition(mousePosition);
        }
        else
            rb.MovePosition(rb.position + movement * 10 * Time.deltaTime);
    }
}

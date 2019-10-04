using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    private string playerName;
    private float xMovement;
    private float yMovement;
    private Vector2 movement;
    private Vector3 mousePosition;
    private bool mouse = false;
    private float speed = 10f;
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        mousePosition = Vector3.zero;
        playerName = gameObject.name;
    }

    void Update()
    {
        if (playerName.Equals("Player1"))
        {
            xMovement = Input.GetAxisRaw("Controller1Horizontal");
            yMovement = Input.GetAxisRaw("Controller1Vertical");          
        }
        else
        {
            xMovement = Input.GetAxisRaw("Controller2Horizontal");
            yMovement = Input.GetAxisRaw("Controller2Vertical");
        }

        movement = new Vector2(xMovement, yMovement);

        /*if (mousePosition != Camera.main.ScreenToWorldPoint(Input.mousePosition))
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mouse = true;
        }*/
    }

    private void FixedUpdate()
    {
        /*if (mouse)
        {
            mouse = false;
            rb.MovePosition(mousePosition);
        }
        else*/
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
}
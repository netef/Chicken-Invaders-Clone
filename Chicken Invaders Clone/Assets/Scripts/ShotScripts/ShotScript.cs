using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotScript : MonoBehaviour
{
    public GameObject explosionEffect;
    private float speed = 15f;
    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.up * speed;
        Destroy(gameObject, 5);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            GameObject die = Instantiate(explosionEffect, collision.transform.position, Quaternion.identity);
            Destroy(die, 1);
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
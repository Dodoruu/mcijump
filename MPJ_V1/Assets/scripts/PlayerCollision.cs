using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
//using System.Diagnostics;
//using System.Diagnostics;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // Start is called before the first frame update
    public float bounceForce = 15f;
    public string bouncerTag = "Bouncer";
    public string cyanTag = "Cyan";
    public string pinkTag = "Pink";
    public string yellowTag = "Yellow";
    public Vector2 bounceDirection;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        UnityEngine.Debug.Log("Trigger with Sauce");
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        if (collision.gameObject.CompareTag(cyanTag))
        {
            UnityEngine.Debug.Log("CYan triggered!s");
            rb.AddForce(bounceDirection * 30f, ForceMode2D.Impulse);
        }
        else if (collision.gameObject.CompareTag(pinkTag))
        {
            rb.AddForce(bounceDirection * 50f, ForceMode2D.Impulse);
        }
        else if (collision.gameObject.CompareTag(yellowTag))
        {
            rb.AddForce(bounceDirection * 80f, ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //UnityEngine.Debug.Log("Collision with Bouncer");
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        if (rb.velocity.y <= 0)
        {
            if (collision.gameObject.CompareTag(bouncerTag))
            {
                //UnityEngine.Debug.Log("Bouncer triggered!s");
                rb.AddForce(bounceDirection * bounceForce, ForceMode2D.Impulse);
            }
        }
    }
}

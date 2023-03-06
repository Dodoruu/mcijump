using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // Start is called before the first frame update
    public float bounceForce = 15f;
    public string bouncerTag = "Bouncer";

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(bouncerTag))
        {
            //Debug.Log("Collision with Bouncer");
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            if (rb.velocity.y <= 0)
            {
                Vector2 bounceDirection = new Vector2(0f, 1f);
                if (collision.gameObject.name == "Cyan")
                {
                    rb.AddForce(bounceDirection * 50f, ForceMode2D.Impulse);
                }
                else if (collision.gameObject.name == "Pink")
                {
                    rb.AddForce(bounceDirection * 150f, ForceMode2D.Impulse);
                }
                else if (collision.gameObject.name == "Yellow")
                {
                    rb.AddForce(bounceDirection * 400f, ForceMode2D.Impulse);
                }   
                else
                {
                    rb.AddForce(bounceDirection * bounceForce, ForceMode2D.Impulse);
                }
            }
        }
    }
}

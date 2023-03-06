using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private float speed = 10f;
    public float velocityY;
    public GameObject player;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Vector2 movement = new Vector2(Input.GetAxis("Horizontal") * speed, rb2d.velocity.y);
        rb2d.velocity = movement;
        velocityY = rb2d.velocity.y;
    }

    void Update()
    {
        float xPosition = player.transform.position.x; // X-Position des Players auslesen

        if (xPosition > 3.5f) // Wenn X-Wert größer als 3.5
        {
            player.transform.position = new Vector3(xPosition - 7f, player.transform.position.y, player.transform.position.z); // X-Wert auf X-Wert - 3.5 setzen
        }
        else if (xPosition < -3.5f) // Wenn X-Wert kleiner als -3.5
        {
            player.transform.position = new Vector3(xPosition + 7f, player.transform.position.y, player.transform.position.z); // X-Wert auf X-Wert + 3.5 setzen
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Ball : MonoBehaviour
{
    public float speed;
    private GameManager manager;
    private Rigidbody2D rb;
    private bool running = false;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        manager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Left")
        {
            manager.Score("Right");
        }
        else if (collision.gameObject.tag == "Right")
        {
            manager.Score("Left");
        }

        running = false;
        rb.velocity = Vector2.zero;
        transform.position = Vector2.zero;
    }

    public void StartGame(InputAction.CallbackContext ctx)
    {
        if (!running)
        {
            rb.velocity = new Vector2(speed, speed);
            running = true;
        }
    }
}

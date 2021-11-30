using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Camera cam;
    public float speed;

    private Dictionary<string, KeyCode> keys = new Dictionary<string, KeyCode>()
    {
        { "up", KeyCode.W },
        { "down", KeyCode.S },
    };

    private void Update()
    {
        Vector2 velocity = new Vector2();

        if (Input.GetKey(keys["up"]))
        {
            velocity.y += speed;
        }

        if (Input.GetKey(keys["down"]))
        {
            velocity.y -= speed;
        }

        transform.Translate(velocity);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Paddle : MonoBehaviour
{
    public float speed;

    private float yClamp;

    private void Awake()
    {
        yClamp = 5 - (transform.localScale.y / 2);
    }

    public void Move(float axis)
    {
        Vector2 pos = transform.position;
        pos += new Vector2(0, axis * speed);
        pos.y = Mathf.Clamp(pos.y, -yClamp, yClamp);
        transform.position = pos;
    }
}

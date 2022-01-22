using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private Paddle pad;
    private float axis = 0;

    private void Awake()
    {
        pad = GetComponent<Paddle>();
    }

    private void FixedUpdate()
    {
        if (axis != 0)
        {
            pad.Move(axis);
        }
    }

    public void GetAxis(InputAction.CallbackContext ctx)
    {
        axis = ctx.ReadValue<float>();
    }
}

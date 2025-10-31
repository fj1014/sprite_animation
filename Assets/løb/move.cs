using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Vector2 movement;
    private Rigidbody2D myBody;
    private Animator myanimator;

    [SerializeField] private float speed = 5f;

    private void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        myanimator = GetComponent<Animator>();
    }

    private void OnMovement(InputValue value)
    {
        movement = value.Get<Vector2>();

        if (movement.x != 0 || movement.y != 0)
        {

            myanimator.SetFloat("x",movement.x);
            myanimator.SetFloat("y",movement.y);

            myanimator.SetBool("iswalking", true);
        }
        else
        {
            myanimator.SetBool("iswalking", false);
        }
    }

    private void FixedUpdate()
    {
        myBody.linearVelocity = movement * speed;
    }
}

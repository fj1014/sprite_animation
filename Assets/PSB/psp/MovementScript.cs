using UnityEngine;
using UnityEngine.InputSystem;

public class MovementScript : MonoBehaviour
{
    private Vector2 movement;
    private Rigidbody2D rb;
    private Animator anim; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame

    public void Move (InputAction.CallbackContext ctx)
    {
        Debug.Log("Test");
        movement = ctx.ReadValue<Vector2>();

        anim.SetFloat ("x", movement.x);
        anim.SetFloat ("y", movement.y);
    }
}

using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float jumpSpeed;

    Rigidbody2D body;

    public PlayerInput input;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        input = GetComponent<PlayerInput>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        float horizMovement = input.actions.FindAction("Move").ReadValue<float>();

        body.AddForceX(horizMovement * speed, ForceMode2D.Impulse);

        bool pressedJump = input.actions.FindAction("Jump").IsPressed();

        if (body.linearVelocityY == 0 && pressedJump)
        {
            body.AddForceY(jumpSpeed, ForceMode2D.Impulse);
        }
    }
}

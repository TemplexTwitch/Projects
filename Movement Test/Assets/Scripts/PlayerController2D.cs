using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2D : MonoBehaviour
{
    [Header("Public Floats")]
    [SerializeField] float MovementSpeed = 2.0f;
    [SerializeField] float JumpSpeed = 4f;
    [SerializeField] float groundRadiusCheck = 0.3f;

    [Header("Rigidbody")]
    Rigidbody2D rb;

    [Header("LayerMask")]
    public LayerMask layers;

    float moveInput;
    bool jumpInput;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        moveInput = Input.GetAxis("Horizontal");
        jumpInput = Input.GetButton("Jump");
    }

    private void FixedUpdate()
    {
        Vector2 vel = rb.velocity;
        vel.x = moveInput * MovementSpeed;
        bool onGround = GroundCheck();

        if (jumpInput == true && onGround)
        {
            vel.y = JumpSpeed;
        }
        rb.velocity = vel;
    }

    bool GroundCheck() 
    {
        Collider2D hitCollider = Physics2D.OverlapCircle(
                            transform.position,
                            groundRadiusCheck,
                            layers);
        return hitCollider != null;
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, groundRadiusCheck);
    }
}

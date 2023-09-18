using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    //Make the rotation speed changeable in the inspector
    public float RotationSpeed = 1f;   
    public float speedboost = 100f; 
    public float slopeCheckDistance = 0.5f; // Adjust the distance for slope checking
    public LayerMask groundLayer;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //add torque to the rigidbody, a for left, d for right
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddTorque(RotationSpeed);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.AddTorque(-RotationSpeed);
        }
        //when pressing space, give the player a speedboost
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Apply the force in the forward direction of the player's transform
            rb.AddForce(transform.right * speedboost, ForceMode2D.Impulse);
        }
    }
     public bool IsGrounded()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, slopeCheckDistance, groundLayer);
        return hit.collider != null;
    }

    // Check if the player is going downhill
    public bool IsGoingDownhill()
    {
        float slopeAngle = Vector2.Angle(Vector2.up, rb.velocity.normalized);

        if (slopeAngle > 90f && IsGrounded())
        {
            return true;
        }
        else return false;
    }

    public float GetSpeed()
    {
        if (rb.velocity.magnitude < 0.01f)
        {
            return -1f;
        }
        return rb.velocity.magnitude;
    }
}

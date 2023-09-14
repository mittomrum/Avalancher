using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    //Make the rotation speed changeable in the inspector
    public float RotationSpeed = 1f;    

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
    }
}

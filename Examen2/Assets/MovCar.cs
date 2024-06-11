using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovCar : MonoBehaviour
{
    public float acceleration = 10f; // Aceleración del carro
    public float steering = 2f;      // Control del giro del carro

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Movimiento hacia adelante y hacia atrás
        float moveInput = Input.GetAxis("Vertical");
        Vector3 moveForce = transform.forward * moveInput * acceleration;
        rb.AddForce(moveForce);

        // Giro del carro
        float turnInput = Input.GetAxis("Horizontal");
        float turn = turnInput * steering * rb.velocity.magnitude * Time.deltaTime;
        Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);
        rb.MoveRotation(rb.rotation * turnRotation);
    }
    
}

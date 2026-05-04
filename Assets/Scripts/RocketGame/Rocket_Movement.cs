using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Rocket_Movement : MonoBehaviour
{
    [SerializeField] InputAction thrust;
    [SerializeField] InputAction rotation;
    [SerializeField] float thrustForce = 100f;

    Rigidbody rb;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }



    private void OnEnable()
    {
        thrust.Enable();
        rotation.Enable();
    }

    void FixedUpdate()
    {
        ProcessThrust();
        ProcessRotation();
    }

    private void ProcessRotation()
    {
        float rotationInput = rotation.ReadValue<float>();
        Debug.Log("here is our rotation value: " + rotationInput);

        if(rotationInput != 0)
        {

            rb.AddRelativeTorque(Vector3.forward * rotationInput * 111 * Time.deltaTime);
        }
    }

    private void ProcessThrust()
    {
        if (thrust.IsPressed())
        {
            rb.AddRelativeForce(Vector3.up * thrustForce * Time.deltaTime);
        }
    }
}
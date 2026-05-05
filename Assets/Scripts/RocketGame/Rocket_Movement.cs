using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Rocket_Movement : MonoBehaviour
{
    [SerializeField] InputAction thrust;
    [SerializeField] InputAction rotation;
    [SerializeField] float thrustForce = 100f;
    [SerializeField] AudioClip mainEngine;

    Rigidbody rb;
    AudioSource audioSource;

    bool isAlive;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
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

        if(rotationInput != 0)
        {

            rb.AddRelativeTorque(-Vector3.forward * rotationInput * 111 * Time.deltaTime);
            
        }

    }

    private void ProcessThrust()
    {
        if (thrust.IsPressed())
        {
            rb.AddRelativeForce(Vector3.up * thrustForce * Time.deltaTime);
            if(!audioSource.isPlaying)
            {
                audioSource.PlayOneShot(mainEngine);
            }
            
        }
    }
}
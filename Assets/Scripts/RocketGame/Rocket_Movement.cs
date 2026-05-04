using UnityEngine;
using UnityEngine.InputSystem;

public class Rocket_Movement : MonoBehaviour
{
    [SerializeField] InputAction thrust;
    [SerializeField] float thrustForce = 100f;

    Rigidbody rb;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }



    private void OnEnable()
    {
        thrust.Enable();
    }

    void FixedUpdate()
    {
        if(thrust.IsPressed())
        {
            rb.AddRelativeForce(Vector3.up * thrustForce * Time.deltaTime);
        }
    }
}

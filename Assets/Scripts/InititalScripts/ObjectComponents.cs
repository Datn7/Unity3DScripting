using UnityEngine;

public class ObjectComponents : MonoBehaviour
{
    Rigidbody rb;
    PlayerHealth health;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.mass = 10;



        GetComponent<Renderer>().material.color = Color.plum;

        health = GetComponent<PlayerHealth>();

        

        health.lives = 9;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

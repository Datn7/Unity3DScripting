using UnityEngine;

public class PlayerMovementBasic : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 1f;
    public float jumpForce = 1f;
    float inputX, inputY;
    bool jump=false;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //rb.linearVelocity = new Vector3(0, 0, speed);
    }

    // Update is called once per frame
    void Update()
    {
        inputX = Input.GetAxis("Horizontal");
        inputY = Input.GetAxis("Vertical");

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
    }

    private void FixedUpdate()
    {
       

        rb.linearVelocity = new Vector3(inputX * speed, rb.linearVelocity.y, inputY * speed);

        if (jump == true)
        {
            Jump();
            jump = false;
        }
    }

    void Jump()
    {
        rb.AddForce(0, jumpForce, 0);
    }
}

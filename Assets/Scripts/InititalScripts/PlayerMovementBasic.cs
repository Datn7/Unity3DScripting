using UnityEngine;

public class PlayerMovementBasic : MonoBehaviour
{
    
    public float speed = 1f;
    public float jumpForce = 1f;
    public float bulletSpeed = 1f;
    public GameObject bullet;
    public Transform bulletPosition;


    Rigidbody rb;
    float inputX, inputY;
    bool jump=false;
    bool shoot = false;

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

        if (Input.GetButtonDown("Fire1"))
        {
            shoot = true;
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

        if (shoot == true)
        { 
            Shoot();
            shoot = false;
        }
    }

    void Jump()
    {
        rb.AddForce(0, jumpForce, 0);
    }

    void Shoot()
    {
        GameObject bulletSpawn = Instantiate(bullet, bulletPosition.position, bullet.transform.rotation);

        bulletSpawn.GetComponent<Rigidbody>().linearVelocity = new Vector3(0, 0, bulletSpeed);
    }

    private void OnDestroy()
    {
        Destroy(rb);
    }
}

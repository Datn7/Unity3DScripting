using UnityEngine;
using UnityEngine.SceneManagement;

public class C_PlayerController : MonoBehaviour
{
    public float speed = 5f;

    Rigidbody rb;

    float xInput;
    float yInput;


    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if(transform.position.y < -10)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    private void FixedUpdate()
    {
        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertical");

        rb.AddForce(xInput, 0, yInput * speed);
    }
}

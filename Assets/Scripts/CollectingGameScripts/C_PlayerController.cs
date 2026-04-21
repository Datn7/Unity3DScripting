using UnityEngine;
using UnityEngine.SceneManagement;

public class C_PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public int WinScore = 3;
    public GameObject WinText;

    Rigidbody rb;

    float xInput;
    float yInput;
    int score = 0;


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


    private void OnTriggerEnter(Collider other)
    {
            if(other.CompareTag("CoinTag"))
        {
            other.gameObject.SetActive(false);

            score++;

            if(score >= WinScore)
            {
                WinText.SetActive(true);
            }
        }
    }

}

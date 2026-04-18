using UnityEngine;

public class MovementBasic : MonoBehaviour
{
    public float speed = 1f;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float yInput = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        transform.Translate(xInput, yInput, 0);
    }
}

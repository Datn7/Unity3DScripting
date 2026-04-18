using UnityEngine;

public class Instancing : MonoBehaviour
{
    public GameObject[] balls;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            int randomNumber = Random.Range(0, balls.Length);

            Instantiate(balls[randomNumber], transform.position, Quaternion.identity);
        }
    }
}

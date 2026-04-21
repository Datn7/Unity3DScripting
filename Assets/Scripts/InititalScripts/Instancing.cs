using UnityEngine;

public class Instancing : MonoBehaviour
{
    public GameObject[] balls;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("RandomBall", 5f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        //on mouse click cancel invoking randomball method
        if (Input.GetMouseButtonDown(0)) 
        {
            CancelInvoke("RandomBall");
        }

    }

    void RandomBall()
    {
        int randomNumber = Random.Range(0, balls.Length);

        Instantiate(balls[randomNumber], transform.position, Quaternion.identity);
    }
}

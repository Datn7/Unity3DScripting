using UnityEngine;
using UnityEngine.Assertions.Must;

public class S_Class_Test : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Classes myCar = new Classes();
        myCar.speed = 10f;
        myCar.Move();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

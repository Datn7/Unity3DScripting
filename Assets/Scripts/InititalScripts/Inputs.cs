using UnityEngine;

public class Inputs : MonoBehaviour
{



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("Space button was pressed");
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            print("Released");
        }

        if (Input.GetKey(KeyCode.Space))
        {
            print("its pressed and hold");
        }
    }
}

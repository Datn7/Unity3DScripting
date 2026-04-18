using UnityEngine;

public class DeadZone : MonoBehaviour
{



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter(Collider other)
    {
        print("you are in bitch!");
    }

    void OnTriggerExit(Collider other)
    {
        print("you are out bitch!");
    }

}

using UnityEngine;

public class LookatTest : MonoBehaviour
{
    public GameObject target;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 newPos = new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z);

        //transform.LookAt(target.transform);

        transform.LookAt(newPos);
    }
}

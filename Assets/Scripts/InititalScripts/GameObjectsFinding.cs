using UnityEngine;

public class GameObjectsFinding : MonoBehaviour
{

    GameObject searchObject;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //searchObject = GameObject.Find("Cube");

       

        searchObject = GameObject.FindWithTag("cubeTag");

        Destroy(searchObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

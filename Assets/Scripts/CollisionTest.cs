using UnityEngine;

public class CollisionTest : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter(Collision collision)
    {

        if(collision.gameObject.tag == "Enemy") 
        {
            Destroy(collision.gameObject);
        }
      
    }
}

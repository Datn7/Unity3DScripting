using UnityEngine;

public class MouseInputCoordinates : MonoBehaviour
{
    public GameObject ball;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            print(Input.mousePosition.x + " " + Input.mousePosition.y);

            Vector3 pos = Input.mousePosition;
            pos.z = 10f;

            pos = Camera.main.ScreenToWorldPoint(pos);

            Instantiate(ball,pos,Quaternion.identity);
        }
    }

   
}

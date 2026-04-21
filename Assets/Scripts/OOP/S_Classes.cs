using UnityEngine;

public class Classes
{
    public float speed = 5f;
    string color = "red";
    int highSpeed = 300;


    public void Move()
    {
        Debug.Log("Moving");
    }

    void Brake()
    {
        Debug.Log("Braking");
    }
}

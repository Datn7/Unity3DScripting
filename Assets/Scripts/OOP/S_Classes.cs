using UnityEngine;

public class Classes
{
    public float speed = 5f;
    public string color = "red";
    public int highSpeed = 300;


    public Classes()
    {
        
    }

    public Classes(float speeda)
    {
        this.speed = speeda;
    }

    public Classes(float speed, string color)
    {
        this.speed = speed;
        this.color = color;
    }

    public void Move()
    {
        Debug.Log("Moving");
    }

    void Brake()
    {
        Debug.Log("Braking");
    }
}

using UnityEngine;

public class S_Inheritance : MonoBehaviour
{



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        S_Enemy enemy = new S_Enemy();
        enemy.Attack();

        S_Dragon dragon = new S_Dragon();
        dragon.Attack();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

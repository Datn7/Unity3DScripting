using System;
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

        S_Properties myScore = new S_Properties();
        myScore.Score = 100;
        myScore.Name = "Player1";
        myScore.Description = "This is a score for Player1";
        myScore.ScoreType = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using UnityEngine;

public class S_Enums : MonoBehaviour
{
    enum eWeaponType
    {
        Sword,
        Bow,
        Staff
    }

    public enum GameState
    {
        MainMenu,
        Playing,
        Paused,
        GameOver,
        Ready
    }

    public GameState currentState = GameState.Playing;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentState = GameState.Ready;
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentState) 
        {
            case GameState.Ready:
                Debug.Log("Game is ready!");
                break;
            case GameState.Playing:
                Debug.Log("Game is playing!");
                break;
            case GameState.Paused:
                Debug.Log("Game is paused!");
                break;
            case GameState.MainMenu:
                Debug.Log("Main menu!");
                break;
            case GameState.GameOver:
                Debug.Log("Game over!");
                break;
        }
    }
}

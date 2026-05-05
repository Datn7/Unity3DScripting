using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Friendly":
                Debug.Log("This thing is friendly");
                break;
            case "Finish":
                Debug.Log("You win!");
                break;
            case "Fuel":
                Debug.Log("20 larisa gaamse!");
                break;
            default:
                Debug.Log("You lose bitch!");
                break;
        }
    }
}

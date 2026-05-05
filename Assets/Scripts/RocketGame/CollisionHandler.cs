using UnityEngine;
using UnityEngine.SceneManagement;

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
                //reload level in 2 seconds, thats what invoke method does, it calls the method after the time specified
                Invoke("ReloadLevel", 2f);
                break;
        }
    }

        public void ReloadLevel(){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }


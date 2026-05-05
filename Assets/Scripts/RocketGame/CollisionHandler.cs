using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    public float levelLoadDelay = 2f;
    [SerializeField] AudioClip success;
    [SerializeField] AudioClip crash;

    AudioSource audioSource;
    

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Friendly":
                Debug.Log("This thing is friendly");
                break;
            case "Finish":
                StartSuccessSequence();
                break;
            case "Fuel":
                Debug.Log("20 larisa gaamse!");
                break;
            default:
                //reload level in 2 seconds, thats what invoke method does, it calls the method after the time specified
                StartCrashSequence();
                break;
        }
    }

        public void ReloadLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    public void StartSuccessSequence()
    {
        audioSource.PlayOneShot(success);
        GetComponent<Rocket_Movement>().enabled = false;
        GetComponent<Rigidbody>().isKinematic = true;
        Invoke("ReloadLevel", levelLoadDelay);
    }

    public void StartCrashSequence()
    {
        audioSource.PlayOneShot(crash);
        GetComponent<Rocket_Movement>().enabled = false;
        Invoke("ReloadLevel", levelLoadDelay);
    }
}


using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    public float levelLoadDelay = 2f;
    [SerializeField] AudioClip success;
    [SerializeField] AudioClip crash;

    AudioSource audioSource;

    bool isControllable = true;


    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!isControllable) { return; }

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
        isControllable = false;
        audioSource.Stop();
        audioSource.PlayOneShot(success);
        GetComponent<Rocket_Movement>().enabled = false;
        GetComponent<Rigidbody>().isKinematic = true;
        Invoke("ReloadLevel", levelLoadDelay);
    }

    public void StartCrashSequence()
    {
        isControllable = false;
        audioSource.Stop();
        audioSource.PlayOneShot(crash);
        GetComponent<Rocket_Movement>().enabled = false;
        Invoke("ReloadLevel", levelLoadDelay);
    }
}


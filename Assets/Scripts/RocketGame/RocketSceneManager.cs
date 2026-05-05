using UnityEngine;
using UnityEngine.SceneManagement;

public class RocketSceneManager : MonoBehaviour
{
    public void LoadMainScene()
    {
        SceneManager.LoadScene(3);
    }
}

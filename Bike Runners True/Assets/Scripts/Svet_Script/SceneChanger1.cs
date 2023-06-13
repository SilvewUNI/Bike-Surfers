using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger1 : MonoBehaviour
{
    public string sceneName; 

    public void ChangeScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
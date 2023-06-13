using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger2 : MonoBehaviour
{
    public string sceneName; 

    public void ChangeScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
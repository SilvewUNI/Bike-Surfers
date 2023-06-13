using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Box"))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}

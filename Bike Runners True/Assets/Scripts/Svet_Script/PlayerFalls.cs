using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerFalls : MonoBehaviour
{
    public float fallThreshold = -10f; // Threshold value to indicate falling off the map
    public string endSceneName = "EndScene";

    private void Update()
    {
        if (transform.position.y < fallThreshold)
        {
            SceneManager.LoadScene(endSceneName);
        }
    }
}

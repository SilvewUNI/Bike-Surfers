using UnityEngine;

public class ObjectDisappearingZone : MonoBehaviour
{
    public GameObject objectToDisappear;
    private bool characterEntered;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Change "Player" to the appropriate tag for your character
        {
            characterEntered = true;
            float cooldown = Random.Range(3f, 10f);
            Invoke("DisappearObject", cooldown);
        }
    }

    private void DisappearObject()
    {
        if (characterEntered)
        {
            objectToDisappear.SetActive(false);
        }
    }
}
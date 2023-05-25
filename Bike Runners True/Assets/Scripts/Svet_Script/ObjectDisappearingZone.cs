using UnityEngine;

public class ObjectDisappearingZone : MonoBehaviour
{
    public GameObject objectToDisappear;
    private bool characterEntered;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            characterEntered = true;
            Invoke("DisappearObject", 3f);
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

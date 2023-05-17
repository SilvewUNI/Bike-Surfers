using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WallDisappear : MonoBehaviour
{
    private bool playerInside = false;
    private bool playerMoving = false;
    private Vector3 lastPosition;
    public GameObject wall;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInside = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (!playerMoving && playerInside)
            {
                // Make the object disappear here
                wall.SetActive(false);
            }
            playerInside = false;
        }
    }

    private void Update()
    {
        // Check if the player is moving
        playerMoving = transform.position != lastPosition;
        lastPosition = transform.position;
    }
}
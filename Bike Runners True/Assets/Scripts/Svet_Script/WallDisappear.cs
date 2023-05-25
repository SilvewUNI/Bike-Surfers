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

            if (!playerMoving && playerInside)
            {
                wall.SetActive(false);
            }
            
        }
    }


    private void Update()
    {
        playerMoving = transform.position != lastPosition;
        lastPosition = transform.position;
    }
}
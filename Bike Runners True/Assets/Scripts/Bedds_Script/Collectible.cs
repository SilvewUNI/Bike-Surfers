using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
   
   public int value;
   public float values;

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter ()
    {
        GameManager.instance.Collect (value, gameObject);

        AudioSource source = GetComponent<AudioSource> ();
        source.Play ();

    }
}

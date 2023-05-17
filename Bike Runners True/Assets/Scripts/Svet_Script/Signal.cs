using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Signal : MonoBehaviour {

    public GameObject signal;

   void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "signalhit") {
            signal.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other) {
        if (other.gameObject.tag == "signalhit") {
            signal.SetActive(false);
        }
    }


}

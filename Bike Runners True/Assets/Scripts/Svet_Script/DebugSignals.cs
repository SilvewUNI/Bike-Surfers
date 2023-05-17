using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugSignals : MonoBehaviour
{
    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Signal") {
            Debug.Log("Collision detected between Object2 and Object3.");
        }
    }

    void OnCollisionExit(Collision collision) {
        if (collision.gameObject.tag == "Signal") {
            Debug.Log("Collision between Object2 and Object3 ended.");
        }
    }


}

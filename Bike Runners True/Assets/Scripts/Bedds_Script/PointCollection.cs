using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PointCollection : MonoBehaviour
{
 
private int Coin = 0;

public TextMeshProUGUI coinText;

private void OnTriggerEnter(Collider other)
{
    if(other.transform.tag == "Coin")
    {
        Coin++;
        coinText.text = "Score: " + Coin.ToString();
        Debug.Log(Coin);
        Destroy(other.gameObject);

        FindObjectOfType<AudioManager>().Play("POINTSOUND");
    }
}

}

using UnityEngine;

public class SignalCheckLeft : MonoBehaviour
{
  public GameObject LeftSignal;
void OnTriggerEnter(Collider other)
    {
        if ( other.gameObject.tag == "RightChecker" )
        {
            if ( LeftSignal.activeInHierarchy )
            {
                //do stuff here
            }
            
            else
            {
                //punish player here
            }
        }
    }
}

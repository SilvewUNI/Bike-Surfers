using UnityEngine;

public class SignalCheckRight: MonoBehaviour
{
    public GameObject RightSignal;
void OnTriggerEnter(Collider other)
    {
        if ( other.gameObject.tag == "RightChecker" )
        {
            if ( RightSignal.activeInHierarchy )
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
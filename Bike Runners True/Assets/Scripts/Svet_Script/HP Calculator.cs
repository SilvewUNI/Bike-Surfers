using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HPCalculator : MonoBehaviour
{
    public int healthPoints = 3;
public void TakeDamage(int damageAmount)
{
    healthPoints -= damageAmount;
    if (healthPoints <= 0)
    {
        SceneManager.LoadScene("EndScreen");
    }
}
}


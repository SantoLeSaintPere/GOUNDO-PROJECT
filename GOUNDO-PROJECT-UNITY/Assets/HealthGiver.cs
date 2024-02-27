using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthGiver : MonoBehaviour
{
    public int lifeToGive = 10;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            other.GetComponent<PlayerHealth>().GiveLife(lifeToGive);
            Destroy(gameObject);
        }
    }
}

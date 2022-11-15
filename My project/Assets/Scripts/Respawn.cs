using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Transform respawnPoint;

    private void OnTriggerEnter(Collider other) 
    {
        if (other.GetComponent<Collider>().tag == "Car") 
        {
            other.gameObject.transform.position = respawnPoint.position;
            other.gameObject.GetComponent<Carmovement>().Reset();            
        }
    }
}

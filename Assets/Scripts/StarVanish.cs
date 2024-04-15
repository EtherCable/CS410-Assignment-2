using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarVanish1 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            this.gameObject.SetActive(false);
        }
    }
}

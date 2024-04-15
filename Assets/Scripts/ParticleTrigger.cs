using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaticleTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //disabling the particle system
        GetComponent<ParticleSystem>().Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Star"))
        {
            //disabling the particle system
            GetComponent<ParticleSystem>().Stop();
            this.gameObject.SetActive(false);
        }
    }
}

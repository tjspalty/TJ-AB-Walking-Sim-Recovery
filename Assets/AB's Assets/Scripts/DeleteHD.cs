using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteHD : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
       Debug.Log("HD Picked");
        if(other.name == "Player Main")
        {
            other.GetComponent<CountHD>().hotdogs++;

            // AudioSource audio = other.GetComponent<AudioSource>(); //Get audio from object
            // audio.Play(); //Play it
            // other.gameObject.SetActive(false);

            Destroy(gameObject);
        }
    }
}

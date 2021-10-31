using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteHD : MonoBehaviour
{

    // public AudioClip audioEating;
    // AudioSource eatingAudio = new AudioSource();

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

            // eatingAudio = GetComponent<AudioSource>(); //Get audio from object
            // eatingAudio.clip = audioEating;
            // eatingAudio.Play(); //Play it
            // other.gameObject.SetActive(false);

            Destroy(gameObject);
        }
    }
}

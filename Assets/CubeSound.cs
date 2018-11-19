using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSound : MonoBehaviour {

    private AudioSource audioSource;

    public AudioClip sound;
    

	// Use this for initialization
	void Start () {

        audioSource = gameObject.AddComponent<AudioSource>();

        audioSource.clip = sound;
        

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "UnityChan2D") {
            audioSource.Play();
        }
    }
}

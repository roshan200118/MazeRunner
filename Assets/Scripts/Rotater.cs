using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This class handles the behaviour of the key
public class Rotater : MonoBehaviour
{
    //Sound when key is picked up
    private AudioSource pickupSound;

    private void Start()
    {
        //Assign the sound
        pickupSound = gameObject.GetComponent<AudioSource>();
    }

    void Update()
    {
        //Rotate the object 60 degrees along the y-axis with respect to time
        transform.Rotate(new Vector3(0, 60, 0) * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        //Play the sound when the key is collided with player
        pickupSound.Play();
    }
}

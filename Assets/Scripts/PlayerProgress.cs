using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerProgress : MonoBehaviour
{
    //Game time text
    public TextMeshProUGUI gameTimeText;

    //If player has key
    public static bool hasKey1, hasKey2, hasKey3;

    //Keep track of game time
    private float gameTimeCounter;

    //The pause canvas
    public Canvas pauseCanvas;

    void Start()
    {
        //Puase canvas should not be active
        pauseCanvas.gameObject.SetActive(false);

        //Player doesn't have keys
        hasKey1 = false;
        hasKey2 = false;
        hasKey3 = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Increase in time
        gameTimeCounter += Time.deltaTime;

        //Calculate time
        int seconds = (int)(gameTimeCounter % 60);
        int minutes = (int)(gameTimeCounter / 60) % 60;
        int hours = (int)(gameTimeCounter / 3600) % 24;

        //Format time into a string
        gameTimeText.text = string.Format("{0:0}:{1:00}:{2:00}", hours, minutes, seconds);

        //Show pause menu if "P" is clicked, let mouse cursor not be locked when pause menu shows
        //Stop time and start time when pause/unpause 
        if (Input.GetKeyDown(KeyCode.P) == true)
        {
            pauseCanvas.gameObject.SetActive(!pauseCanvas.gameObject.activeInHierarchy);

            if (pauseCanvas.gameObject.activeInHierarchy)
            {
                Cursor.lockState = CursorLockMode.None;
                Time.timeScale = 0;
            }
            else
            {
                Cursor.lockState = CursorLockMode.Locked;
                Time.timeScale = 1;
            }
        }
    }

    //If player runs into key, player has that key
    private void OnTriggerEnter(Collider other)
    {
        //If the player collides with any key, play the pickupAudio
        if (other.gameObject.layer == 7)
        {
            AudioSource audio = other.GetComponentInParent<AudioSource>();
            audio.time = 0.3f;
            audio.Play();
        }

        if (other.CompareTag("Key1"))
        {
            other.gameObject.SetActive(false);

            hasKey1 = true;
        }
        else if (other.CompareTag("Key2"))
        {
            other.gameObject.SetActive(false);
            hasKey2 = true;
        }
        else if (other.CompareTag("Key3"))
        {
            other.gameObject.SetActive(false);
            hasKey3 = true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerProgress : MonoBehaviour
{
    public TextMeshProUGUI gameTimeText;

    public static bool hasKey1, hasKey2, hasKey3;
    private float gameTimeCounter;


    // Start is called before the first frame update
    void Start()
    {
        hasKey1 = true;
        hasKey2 = true;
        hasKey3 = true;
    }

    // Update is called once per frame
    void Update()
    {
        gameTimeCounter += Time.deltaTime;

        int seconds = (int)(gameTimeCounter % 60);
        int minutes = (int)(gameTimeCounter / 60) % 60;
        int hours = (int)(gameTimeCounter /3600) % 24;

        gameTimeText.text = string.Format("{0:0}:{1:00}:{2:00}", hours, minutes, seconds);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Key1"))
        {
            print("KEY1");
            other.gameObject.SetActive(false);
            hasKey1 = true;
        }
        else if (other.CompareTag("Key2"))
        {
            print("KEY2");
            other.gameObject.SetActive(false);
            hasKey2 = true;
        }
        else if (other.CompareTag("Key3"))
        {
            print("KEY3");
            other.gameObject.SetActive(false);
            hasKey3 = true;
        }

        if(other.CompareTag("FinishLine"))
        {
            print("GAME DONE");
        }
    }
}

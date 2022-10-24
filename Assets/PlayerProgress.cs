using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProgress : MonoBehaviour
{
    public static bool hasKey1, hasKey2, hasKey3;


    // Start is called before the first frame update
    void Start()
    {
        hasKey1 = true;
    }

    // Update is called once per frame
    void Update()
    {
        
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
    }
}

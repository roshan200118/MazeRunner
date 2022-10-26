using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Handles door opening logic
public class DoorController : MonoBehaviour
{
    public GameObject character;
    public float distance = 10f;
    private Animator animator;

    //Different for each door
    private string doorName;

    void Start()
    {
        //Get the animation component from corresponding door
        animator = GetComponent<Animator>();

        //Save the door's tag
        doorName = this.gameObject.tag;
    }

    void Update()
    {
        //For each corresponding door, check if player is in distance, and check if player has corresponding key. Then allow door to play animation and open.
        if (Vector3.Distance(character.transform.position, transform.position) <= distance && doorName == "Door1" && PlayerProgress.hasKey1 == true)
        {
            animator.SetBool("character_nearby", true);
        }
        else if (Vector3.Distance(character.transform.position, transform.position) <= distance && doorName == "Door2" && PlayerProgress.hasKey2 == true)
        {
            animator.SetBool("character_nearby", true);
        }
        else if (Vector3.Distance(character.transform.position, transform.position) <= distance && doorName == "Door3" && PlayerProgress.hasKey3 == true)
        {
            animator.SetBool("character_nearby", true);
        }

        //If player has all the keys and is at final door, then open
        else if (Vector3.Distance(character.transform.position, transform.position) <= distance && doorName == "DoorFinish"
            && PlayerProgress.hasKey3 == true && PlayerProgress.hasKey2 == true && PlayerProgress.hasKey1 == true)
        {
            animator.SetBool("character_nearby", true);
        }
        else
        {
            animator.SetBool("character_nearby", false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public GameObject character;
    public float distance = 10f;
    private Animator animator;
    private string doorName;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        doorName = this.gameObject.tag;
    }

    // Update is called once per frame
    void Update()
    {
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
        else
        {
            animator.SetBool("character_nearby", false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationStateController : MonoBehaviour
{
    Animator animator;


    void Start()
    {
        animator = GetComponent<Animator>();


    }

    
    void Update()
    {
        //if players presses forward (W) key
        if (Input.GetKey("w"))
        {
            //then iswalking boolean is set to true
            animator.SetBool("isWalking", true);
        }

        //if the player is not pressing forwards (w)
        if (!Input.GetKey("w"))
        {
            //iswalking boolean is set to false
            animator.SetBool("isWalking", false);
        }


    }
}

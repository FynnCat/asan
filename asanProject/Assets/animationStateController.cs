using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationStateController : MonoBehaviour
{
    Animator animator;
    int isWalkingHash;


    void Start()
    {
        animator = GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash("isWalking");


    }

    
    void Update()
    {
        bool isWalking = animator.GetBool("isWalking");
        bool forwardPressed = Input.GetKey("w");


        //if players presses forward (W) key
        if (!isWalking && forwardPressed)
        {
            //then iswalking boolean is set to true
            animator.SetBool(isWalkingHash, true);
        }

        //if the player is not pressing forwards (w)
        if (isWalking & !forwardPressed)
        {
            //iswalking boolean is set to false
            animator.SetBool(isWalkingHash, false);
        }


    }
}

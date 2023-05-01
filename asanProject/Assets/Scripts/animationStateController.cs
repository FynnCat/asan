using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationStateController : MonoBehaviour
{
    Animator animator;
    int isWalkingHash;
    int isWalkingleftHash;


    void Start()
    {
        animator = GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash("isWalking");
        isWalkingleftHash = Animator.StringToHash("isWalkingLeft");


    }

    
    void Update()
    {
        bool isWalking = animator.GetBool("isWalking");
        bool forwardPressed = Input.GetKey("w");

        bool isWalkingleft = animator.GetBool("isWalkingleft");
        bool leftPressed = Input.GetKey("a");


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

        //if players presses forward (a) key
        if (!isWalkingleft && leftPressed)
        {
            //then iswalking boolean is set to true
            animator.SetBool(isWalkingleftHash, true);
        }

        //if the player is not pressing forwards (a)
        if (isWalkingleft && !leftPressed)
        {
            //iswalking boolean is set to false
            animator.SetBool(isWalkingleftHash, false);
        }


    }
}

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

        float HorizontalInput = Input.GetAxis("Horizontal");
        float VerticalInput = Input.GetAxis("Vertical");

      

        animator.SetFloat("Horizontal", HorizontalInput, 0.05f, Time.deltaTime);
        animator.SetFloat("Vertical", VerticalInput, 0.05f, Time.deltaTime);
    }
}


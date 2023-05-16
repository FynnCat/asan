using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Spider_Anim_Test : MonoBehaviour
{
    public Animator anim;
    public Animator anim2;
    public Animator anim3;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("Change");
        }

        if(Input.GetKeyDown(KeyCode.LeftAlt))
        {
            anim2.SetTrigger("Change");
        }

        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            anim3.SetTrigger("Change");
        }
        
    }
}

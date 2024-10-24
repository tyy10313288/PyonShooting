using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanAnimator : MonoBehaviour
{
    Animator am;
    PlayerMovement pm;
    SpriteRenderer sr;

    void Start()
    {
        am = GetComponent<Animator>();
        pm = GetComponent<PlayerMovement>();
        sr = GetComponent<SpriteRenderer>();
    }


    void Update()
    {
        if (pm.moveDir.x != 0 || pm.moveDir.y != 0)
        {
            am.SetBool("Walk", true);
            am.SetBool("Idle", false);
        }
        else
        {
            am.SetBool("Walk", false);
            am.SetBool("Idle", true);
        }
        if(pm.moveSpeed > 0 && pm.moveDir.x > 0)
        {
            am.SetFloat("X", 1);
        }
        else if (pm.moveSpeed > 0 && pm.moveDir.x < 0)
        {
            am.SetFloat("X", -1);
        }
        if (pm.moveSpeed > 0 && pm.moveDir.y > 0)
        {
            //am.SetFloat("Y", 1);
        }
        else if (pm.moveSpeed > 0 && pm.moveDir.y < 0)
        {
            am.SetFloat("Y", -1);
        }
    }
}

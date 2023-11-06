using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    public Animator animator;

    public void Jump()
    {
        animator.SetTrigger("Jump");
    }

    public void Move(float vitesse)
    {
        animator.SetFloat("vitesse", vitesse);
    }

    public void SetAxis(float X, float Z)
    {
        animator.SetFloat("X", X);
        animator.SetFloat("Z", Z);
    }
}

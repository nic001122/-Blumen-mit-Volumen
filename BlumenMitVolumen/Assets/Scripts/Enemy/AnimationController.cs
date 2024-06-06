using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator animator;
    public RuntimeAnimatorController newController;

    // Start is called before the first frame update
    void Start()
    {
        animator.runtimeAnimatorController = newController;
    }
}

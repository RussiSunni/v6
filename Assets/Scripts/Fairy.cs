using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fairy : MonoBehaviour
{
    public static Animator animator;

    private void Update()
    {
        animator.SetBool("isJump", false);

        animator.SetBool("isHi", false);
    }

}
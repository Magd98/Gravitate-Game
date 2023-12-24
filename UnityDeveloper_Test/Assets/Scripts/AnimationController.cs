using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    Animator animator;
   
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        RunningAnimation();
        JumpAnimation();
    }

    void RunningAnimation()
    {
        bool isRunning = animator.GetBool("isRunning");
        bool fowardRunning = Input.GetKey(KeyCode.W);
        bool backRunning = Input.GetKey(KeyCode.S);
        bool rightSideRunning = Input.GetKey(KeyCode.D);
        bool leftSideRunning = Input.GetKey(KeyCode.A);
        bool jumping = Input.GetKey(KeyCode.Space);

        if (!isRunning && (fowardRunning || backRunning || rightSideRunning || leftSideRunning))
        {
            animator.SetBool("isRunning", true);
        }
        if (isRunning && (!fowardRunning && !backRunning && !rightSideRunning && !leftSideRunning))
        {
            animator.SetBool("isRunning", false);
        }
        if ((fowardRunning || backRunning || rightSideRunning || leftSideRunning) && jumping)
        {
            animator.SetBool("isRunning", false);
            animator.SetBool("isFalling", true);
        }
    }

    void JumpAnimation()
    {

        {
            bool isFalling = animator.GetBool("isFalling");
            bool jumping = Input.GetKey(KeyCode.Space);

            if (!isFalling && jumping)
            {
                animator.SetBool("isFalling", true);
                animator.SetBool("isRunning", false);

            }

            if (isFalling && !jumping)
            {
                animator.SetBool("isFalling", false);

            }

        }
    }
}

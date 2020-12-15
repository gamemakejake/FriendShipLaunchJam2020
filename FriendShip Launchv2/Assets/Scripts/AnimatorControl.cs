﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorControl : MonoBehaviour
{

    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetBool("MoveUpBool", true);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            animator.SetBool("MoveUpBool", false);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetBool("MoveDownBool", true);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            animator.SetBool("MoveDownBool", false);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetBool("MoveLeftBool", true);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            animator.SetBool("MoveLeftBool", false);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetBool("MoveRightBool", true);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            animator.SetBool("MoveRightBool", false);
        }
    }
}

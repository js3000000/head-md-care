using UnityEngine;
using UnityEngine.InputSystem;
using Yarn.Unity;

public class AnnaMoves : MonoBehaviour
{

    private Animator animator;


    // enunm MoveType
    public enum MoveType
    {
        Idle,
        Walking,
        Sitting,
        SittingIdle,
        StartWalking,
        StopWalking
    }
    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    [YarnCommand("AnnaMoves")]
    public void PickAnnasMoves(MoveType moveType)
    {

        switch (moveType)
        {
            case MoveType.Idle:
                animator.SetBool("IsWalking", false);
                animator.SetBool("IsSitting", false);
                break;
            case MoveType.Walking:
                animator.SetBool("IsWalking", true);
                animator.SetBool("IsSitting", false);
                break;
       
        }

        /*
        switch (moveType)
        {
            case MoveType.Idle:
                animator.SetBool("IsWalking", false);
                animator.SetBool("IsSitting", false);
                break;
            case MoveType.Walking:
                animator.SetBool("IsWalking", true);
                animator.SetBool("IsSitting", false);
                break;
            case MoveType.Sitting:
                animator.SetBool("IsWalking", false);
                animator.SetBool("IsSitting", true);
                break;
            case MoveType.SittingIdle:
                animator.SetBool("IsWalking", false);
                animator.SetBool("IsSitting", true);
                break;
            case MoveType.StartWalking:
                animator.SetTrigger("StartWalking");
                break;
            case MoveType.StopWalking:
                animator.SetTrigger("StopWalking");
                break;
        }*/
    }



/*
    void Update()
    {
        if (Keyboard.current.wKey.wasPressedThisFrame)
        {
            animator.SetBool("IsWalking", true);
        }

        if (Keyboard.current.sKey.wasPressedThisFrame)
        {
            animator.SetBool("IsWalking", false);
        }
    }*/
}
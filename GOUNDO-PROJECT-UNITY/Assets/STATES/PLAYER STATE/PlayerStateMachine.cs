using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine : StateMachine
{
    [HideInInspector]
    public PlayerInputReader inputReader;

    [HideInInspector]
    public CharacterController characterController;

    [HideInInspector]
    public Animator animator;

    [HideInInspector]
    public PlayerGroundDetector groundDetector;

    public float speed = 1f;
    [HideInInspector]
    public float yLook;
    public float rotSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        inputReader = GetComponent<PlayerInputReader>();
        characterController = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
        groundDetector = GetComponent<PlayerGroundDetector>();
        NextState(new PlayerMoveState(this));
    }
}

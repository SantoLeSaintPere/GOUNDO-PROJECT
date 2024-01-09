using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTest : MonoBehaviour
{
    PlayerInputReader inputReader;
    Vector3 moveDir;
    public float speed = 1f;

    CharacterController characterController;    
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        inputReader = GetComponent<PlayerInputReader>();
        characterController = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        moveDir = new Vector3(inputReader.moveValue.x,0, inputReader.moveValue.y);

        characterController.Move(moveDir * speed * Time.deltaTime);

        if(inputReader.isMoving)
        {
            animator.SetBool("isMoving", true);
        }

        else
        {
            animator.SetBool("isMoving", false);
        }
    }
}

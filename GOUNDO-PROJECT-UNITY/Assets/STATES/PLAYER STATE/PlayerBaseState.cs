using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public abstract class PlayerBaseState : State
{
    protected PlayerStateMachine stateMachine;

    protected PlayerBaseState(PlayerStateMachine stateMachine)
    {
        this.stateMachine = stateMachine;
    }

    protected void Rotate()
    {
        stateMachine.yLook += stateMachine.inputReader.yValue * (stateMachine.rotSpeed * 10) * Time.deltaTime;
        Quaternion newRot = Quaternion.Euler(0, stateMachine.yLook, 0);

        stateMachine.transform.rotation = newRot;
    }

    protected void Move()
    {
        Vector3 dir = new Vector3(stateMachine.inputReader.moveValue.x, 0, stateMachine.inputReader.moveValue.y);


        dir = Quaternion.AngleAxis(stateMachine.transform.rotation.eulerAngles.y, Vector3.up) * dir;
        dir.Normalize();

        if(stateMachine.groundDetector.isGrounded)
        {
            stateMachine.characterController.Move(dir * stateMachine.speed * Time.deltaTime);
        }



        if (stateMachine.inputReader.isMoving)
        {
            stateMachine.animator.SetBool("isMoving", true);
        }

        else
        {
            stateMachine.animator.SetBool("isMoving", false);
        }
    }
}

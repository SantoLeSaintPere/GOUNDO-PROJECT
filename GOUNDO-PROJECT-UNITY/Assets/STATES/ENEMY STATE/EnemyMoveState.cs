using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveState : EnemyBaseState
{
    public EnemyMoveState(EnemyStateMachine stateMachine) : base(stateMachine)
    {
    }

    public override void InStart()
    {
    }

    public override void InUpdate()
    {

        if (stateMachine.detectionManager.alertStage == AlertStage.peaceful)
        {
            Patrol();
        }

        if (stateMachine.detectionManager.alertStage == AlertStage.intrigued)
        {
            NoMove();
        }


        if (stateMachine.detectionManager.alertStage == AlertStage.alerted)
        {
            stateMachine.NextState(new EnemyChaseState(stateMachine));
        }


    }

    public override void OnExit()
    {
    }
}

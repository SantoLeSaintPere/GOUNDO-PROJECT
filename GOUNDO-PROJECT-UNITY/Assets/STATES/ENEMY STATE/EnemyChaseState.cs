using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChaseState : EnemyBaseState
{
    public EnemyChaseState(EnemyStateMachine stateMachine) : base(stateMachine)
    {
    }

    public override void InStart()
    {
    }

    public override void InUpdate()
    {
        Chase();

        if (stateMachine.detectionManager.alertStage == AlertStage.peaceful)
        {
            stateMachine.NextState(new EnemyMoveState(stateMachine));
        }

        if (stateMachine.detectionManager.alertStage == AlertStage.intrigued)
        {
            NoMove();
        }
    }

    public override void OnExit()
    {
    }
}

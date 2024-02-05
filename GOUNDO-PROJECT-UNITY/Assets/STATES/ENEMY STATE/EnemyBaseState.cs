using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyBaseState : State
{
    protected EnemyStateMachine stateMachine;

    protected EnemyBaseState(EnemyStateMachine stateMachine)
    {
        this.stateMachine = stateMachine;
    }

    protected void Patrol()
    {
        stateMachine.agent.speed = stateMachine.patrolSpeed;
        stateMachine.agent.isStopped = false;

        Vector3 pos = new Vector3(stateMachine.waypoint[stateMachine.currentWaypoint].position.x, stateMachine.transform.position.y, stateMachine.waypoint[stateMachine.currentWaypoint].position.z);
        stateMachine.agent.SetDestination(pos);
        if(stateMachine.transform.position == pos)
        {
            if(stateMachine.currentWaypoint < stateMachine.waypoint.Length)
            {
                stateMachine.currentWaypoint++;
            }

            if(stateMachine.currentWaypoint == stateMachine.waypoint.Length)
            {
                stateMachine.currentWaypoint = 0;
            }
        }
    }

    protected void Chase()
    {
        stateMachine.agent.speed = stateMachine.chaseSpeed;
        stateMachine.agent.isStopped = false;

        stateMachine.agent.SetDestination(stateMachine.detectionManager.playerTarget.position);
    }

    protected void NoMove()
    {
        stateMachine.agent.isStopped = true;
    }
}

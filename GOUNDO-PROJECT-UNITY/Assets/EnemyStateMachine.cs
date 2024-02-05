using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyStateMachine : StateMachine
{
    [HideInInspector]
    public NavMeshAgent agent;
    [HideInInspector]
    public EnemyDetectionManager detectionManager;

    public float patrolSpeed;
    public float chaseSpeed;
    public Transform[] waypoint;

    public int currentWaypoint;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        detectionManager = GetComponent<EnemyDetectionManager>();

        currentWaypoint = 0;
        NextState(new EnemyMoveState(this));
        
    }
}

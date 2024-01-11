using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    State currentState;

    public void NextState(State newState)
    {
        currentState?.OnExit();
        currentState = newState;
        currentState?.InStart();
    }

    void Update()
    {
        currentState?.InUpdate();
    }
}

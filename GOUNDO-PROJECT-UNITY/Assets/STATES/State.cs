using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State
{
    public abstract void InStart();
    public abstract void InUpdate();
    public abstract void OnExit();
}

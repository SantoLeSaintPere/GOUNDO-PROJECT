using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputReader : MonoBehaviour
{
    MyPlayerInputs playerInputs;
    // Start is called before the first frame update
    public Vector2 moveValue;
    public bool isMoving;
    private void Awake()
    {
        playerInputs = new MyPlayerInputs();
    }

    private void OnEnable()
    {
        playerInputs.Player.Enable();
    }

    private void OnDisable()
    {
        playerInputs.Player.Disable();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveValue = playerInputs.Player.MOVE.ReadValue<Vector2>();
        isMoving = moveValue.x !=0 || moveValue.y !=0;
    }
}

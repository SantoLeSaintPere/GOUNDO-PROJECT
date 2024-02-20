using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGroundDetector : MonoBehaviour
{
    public Transform groundDetectorHolder;
    public Transform groundDetector;
    public float range;
    public bool isGrounded;
    public LayerMask groundLayer;

    PlayerInputReader inputReader;
    // Start is called before the first frame update
    void Start()
    {
        inputReader = GetComponent<PlayerInputReader>();
    }

    // Update is called once per frame
    void Update()
    {
        Rotate();

        isGrounded = Physics.Raycast(groundDetector.position, Vector3.down, range);
    }

    void Rotate()
    {
        Vector3 dir = new Vector3(inputReader.moveValue.x, 0, inputReader.moveValue .y);
        groundDetectorHolder.rotation = Quaternion.LookRotation(dir, Vector3.up);
    }

    private void OnDrawGizmos()
    {
        Debug.DrawRay(groundDetector.position, Vector3.down * range, Color.green);

    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public enum AlertStage
{
    peaceful, intrigued, alerted
}

public class EnemyDetectionManager : MonoBehaviour
{
    public AlertStage alertStage;

    [HideInInspector]
    public Color color;
    public Color[] colors;
    public float fov = 90;
    [Range(0, 360)]
    public float fovAngle;

    [Header("ALERT LEVEL")]
    [Range(0,100)]
    public float alertLevel;

    [Header("OTHERS SETTINGS")]
    public bool playerInFov;
    public LayerMask playerLayer;

    [HideInInspector]
    public Transform playerTarget;

    private void Awake()
    {
        alertStage = AlertStage.peaceful; 
        alertLevel = 0;
    }
    // Start is called before the first frame update
    void Start()
    {
        playerTarget = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        playerInFov = false;
        Collider[] target = Physics.OverlapSphere(transform.position, fov, playerLayer);

        foreach (Collider coll in target )
        {
            float signedAngle = Vector3.Angle(transform.forward, playerTarget.position - transform.position);

            if (Math.Abs(signedAngle) < fovAngle / 2)
            {
                playerInFov = true;
            }
        }

        UpdateEnemyState(playerInFov);
    }

    private void UpdateEnemyState(bool playerInFov)
    {
        switch(alertStage)
        {
            case AlertStage.peaceful:
                if(playerInFov)
                {
                    alertStage = AlertStage.intrigued;
                }
                break;

                case AlertStage.intrigued:
                if(playerInFov)
                {
                    alertLevel++;
                    if(alertLevel >= 100)
                    {
                        alertStage = AlertStage.alerted;
                    }
                }

                else
                {
                    alertLevel--;
                    if (alertLevel <= 0)
                    {
                        alertStage = AlertStage.peaceful;
                    }
                }

                break;

            case AlertStage.alerted:
                if(!playerInFov)
                {
                    alertStage = AlertStage.intrigued;
                }
                break;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


[CustomEditor(typeof(EnemyDetectionManager))]
public class EnemyManagerEdtior : Editor
{

    private void OnSceneGUI()
    {
        EnemyDetectionManager detection = (EnemyDetectionManager)target;

        if(detection.alertStage == AlertStage.intrigued)
        {
            detection.color = Color.Lerp(detection.colors[0], detection.colors[1], detection.alertLevel / 100f);
        }

        else if(detection.alertStage == AlertStage.alerted)
        {
            detection.color = detection.colors[1];
        }


        Handles.color = detection.color;
        Handles.DrawSolidArc(detection.transform.position, 
            detection.transform.up, 
            Quaternion.AngleAxis(- detection.fovAngle / 2f, detection.transform.up) * detection.transform.forward,
            detection.fovAngle,
            detection.fov);

        Handles.color = detection.colors[0];
        detection.fov = Handles.ScaleValueHandle(
            detection.fov, 
            detection.transform.position + detection.transform.forward * detection.fov,
            detection.transform.rotation,
            3, 
            Handles.SphereHandleCap,
            1);

    }
}

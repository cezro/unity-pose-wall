using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Angles : ScriptableObject
{
    public Vector3 neckAngle;
    public Vector3 torsoAngle;
    public Vector3 leftShoulderAngle;
    public Vector3 rightShoulderAngle;
    public Vector3 leftElbowAngle;
    public Vector3 rightElbowAngle;
    public Vector3 leftHipAngle;
    public Vector3 rightHipAngle;
    public Vector3 leftKneeAngle;
    public Vector3 rightKneeAngle;

    private void OnDisable()
    {
        
    }
}

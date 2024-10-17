using System;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Transform player;

    private const float xPosition = 0;
    private const float yPosition = 8;
    private const float zPosition = -12;

    private Vector3 followTransform = new Vector3(xPosition, yPosition, zPosition);

    void Update()
    {
        transform.position = player.transform.position + followTransform;
    }
}
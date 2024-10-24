using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnWallHit : MonoBehaviour
{
    private void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 3)
        {
            Debug.Log("Hit wall");
        }
        else
        {
            Debug.Log("safe");
        }
    }
}
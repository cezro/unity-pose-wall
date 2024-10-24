using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnWallHit : MonoBehaviour
{
    public GameEvent onPlayerHit;
    private void Update()
    {

    }

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 3)
        {
            onPlayerHit.Raise(null, null);
            Debug.Log("Hit wall");
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWall : MonoBehaviour
{
    private void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
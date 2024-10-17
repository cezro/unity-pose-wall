using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantVelocity : MonoBehaviour
{
    private new Rigidbody rigidbody;
    [SerializeField] private WallProperties properties;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }


    void Update()
    {
        MoveWall();
    }

    void MoveWall()
    {
        Vector3 direction = new Vector3(0, 0, -1);
        rigidbody.MovePosition(transform.position + direction * Time.deltaTime * properties.speed);
    }
}

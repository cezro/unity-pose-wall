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
        rigidbody.velocity = new Vector3(rigidbody.velocity.x, rigidbody.velocity.y, properties.speed * -1 * Time.deltaTime * 1000);
    }
}

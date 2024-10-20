using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Principal;
using UnityEngine;

public class WallSpawner : MonoBehaviour
{
    public WallProperties wallProperties;
    public Walls walls;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnWall());
    }   


    private IEnumerator SpawnWall()
    {
        while (true) {
            int randomIndex = UnityEngine.Random.Range(0, walls.wall.Count);
            UnityEngine.Debug.Log(randomIndex);
            Instantiate(walls.wall[randomIndex], transform.position, Quaternion.Euler(0, 90, 0));

            yield return new WaitForSeconds(2/wallProperties.frequency);
        }
    }
}

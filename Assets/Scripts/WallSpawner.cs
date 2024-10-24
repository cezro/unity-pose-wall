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
    private GameObject wall;
    [SerializeField] private bool isActive = true;
    [SerializeField] private float wallScale = 1f;

    void Start()
    {
        StartCoroutine(SpawnWall());
    }   

    private IEnumerator SpawnWall()
    {
        while (isActive) {
            int randomIndex = UnityEngine.Random.Range(0, walls.wall.Count);
            wall = Instantiate(walls.wall[randomIndex], transform.position, Quaternion.Euler(0, 90, 0));
            wall.transform.localScale = new Vector3(1,1.4f * wallScale ,wallScale);
            if (wallProperties.frequency > 0)
            {
                yield return new WaitForSeconds(60 / wallProperties.frequency);
            }
            else
            {
                UnityEngine.Debug.LogWarning("Frequency is zero or negative. Skipping spawn delay.");
                yield return null;
            }
        }
    }

    public void Deactivate()
    {
        isActive = false;
    }

    public void Active()
    {
        isActive = true;
    }

}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpawner : MonoBehaviour
{
    public WallProperties wallProperties;
    public Walls walls;
    private GameObject wall;
    [SerializeField] private bool isActive = false;
    [SerializeField] private float wallScale = 1f;
    private float spawnTimer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        if (wallProperties == null || walls == null || walls.wall.Count == 0)
        {
            UnityEngine.Debug.LogError("WallProperties or Walls is not set or walls list is empty!");
            isActive = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!isActive) return;

        // If frequency is set correctly, update the timer and spawn when it reaches the delay threshold
        if (wallProperties.frequency > 0)
        {
            spawnTimer += Time.deltaTime;
            float spawnInterval = 60 / wallProperties.frequency;

            if (spawnTimer >= spawnInterval)
            {
                SpawnWall();
                spawnTimer = 0f; // Reset the timer after spawning a wall
            }
        }
        else
        {
            UnityEngine.Debug.LogWarning("Frequency is zero or negative. Skipping wall spawning.");
        }
    }

    private void SpawnWall()
    {
        int randomIndex = UnityEngine.Random.Range(0, walls.wall.Count);
        wall = Instantiate(walls.wall[randomIndex], transform.position, Quaternion.Euler(0, 90, 0));
        wall.transform.localScale = new Vector3(1, 1.4f * wallScale, wallScale);
        UnityEngine.Debug.Log("Wall spawned.");
    }

    public void Deactivate()
    {
        isActive = false;
        UnityEngine.Debug.Log("Wall spawner deactivated.");
    }

    public void Activate()
    {
        isActive = true;
        UnityEngine.Debug.Log("Wall spawner activated.");
    }
}
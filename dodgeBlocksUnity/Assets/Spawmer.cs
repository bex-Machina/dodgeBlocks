using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawmer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cube;
    Vector2 halfWidth;
    public float secondsBetweenSpawns = 1;
    public float nextSpawnTime;
    void Start()
    {
        halfWidth = new Vector2( Camera.main.aspect * Camera.main.orthographicSize, Camera.main.orthographicSize); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawnTime)
        {
            nextSpawnTime = Time.time + secondsBetweenSpawns;
            Vector2 spawnPoint = new Vector2 (Random.Range(-halfWidth.x, halfWidth.x), halfWidth.y+0.5f);
            Instantiate(cube, spawnPoint, Quaternion.identity);
        }
    }
}

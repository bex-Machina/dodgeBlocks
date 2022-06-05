using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawmer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Block;
    Vector2 halfWidth;
    public float secondsBetweenSpawns = 1;
    public float nextSpawnTime;
    public Vector2 spawnSizeMinMax;
    public float spawnAngleMax;
    void Start()
    {
        halfWidth = new Vector2( Camera.main.aspect * Camera.main.orthographicSize, Camera.main.orthographicSize); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawnTime)
        {
            float spawnAngle = Random.Range(-spawnAngleMax, spawnAngleMax);
            float spawnSize = Random.Range(spawnSizeMinMax.x, spawnSizeMinMax.y);
            nextSpawnTime = Time.time + secondsBetweenSpawns;
            Vector2 spawnPoint = new Vector2 (Random.Range(-halfWidth.x, halfWidth.x), halfWidth.y+ spawnSize);
            GameObject newBlock = (GameObject)Instantiate(Block, spawnPoint, Quaternion.Euler(Vector3.forward*spawnAngle));
            newBlock.transform.localScale = Vector2.one * spawnSize;
        }
    }
}

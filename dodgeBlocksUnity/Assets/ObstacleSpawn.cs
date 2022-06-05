using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawn : MonoBehaviour
{
    public GameObject cube;
    float ScreenWidth;
    public float spawnTime = 3f;
    float height;
    // Start is called before the first frame update
    void Start()
    {
        Camera cam = Camera.main;
        height = transform.localScale.y + cam.orthographicSize;
        ScreenWidth = (height * cam.aspect)*2f;
        InvokeRepeating("spawnCube", spawnTime, spawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnCube()
    {
        Vector2 position = new Vector2(0, height);
        Instantiate(cube, position, Quaternion.identity);
    }
}

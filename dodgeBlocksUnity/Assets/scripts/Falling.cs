using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling : MonoBehaviour
{
    public Vector2 speedMinMax; 
    // Update is called once per frame
    void Update()
    {
        float speed = Mathf.Lerp(speedMinMax.x, speedMinMax.y, Difficulty.GetDifficultyPercent());
        print(speed);
        transform.Translate(Vector2.down * speed * Time.deltaTime);
        if (transform.position.y < -Camera.main.orthographicSize - transform.localScale.y)
        {
            Destroy(this.gameObject);
        }
    }
}

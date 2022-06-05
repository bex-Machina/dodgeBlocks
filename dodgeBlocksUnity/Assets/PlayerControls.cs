using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    float speed = 7f;
    float halfWidth;
    
    // Start is called before the first frame update
    void Start()
    {
        float halfPlayer = transform.localScale.x/2f;
        halfWidth = Camera.main.aspect * Camera.main.orthographicSize + halfPlayer;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), 0);
        Vector2 velocity = input * speed;
        transform.Translate(Vector2.right * velocity * Time.deltaTime);
        if(transform.position.x < -halfWidth)
        {
            transform.position = new Vector3(halfWidth, transform.position.y);
        }
        else if (transform.position.x > halfWidth)
        {
            transform.position = new Vector3(-halfWidth, transform.position.y);
        }
    }
}

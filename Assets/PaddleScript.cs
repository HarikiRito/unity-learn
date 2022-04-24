using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour
{
    public Camera mainCamera;
    public float speed = 10f;

    public float rightEdge;
    public float leftEdge;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        var t = transform;
        
        if (t.position.x < leftEdge)
        {
            t.position = new Vector2(leftEdge, t.position.y);
        }
        
        if (t.position.x > rightEdge)
        {
            t.position = new Vector2(rightEdge, t.position.y);
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            t.Translate(Vector2.left * (Time.deltaTime * speed));
        }
        else if (Input.GetKey(KeyCode.D))
        {
            t.Translate(Vector2.right * (Time.deltaTime * speed));
        }
    }
}
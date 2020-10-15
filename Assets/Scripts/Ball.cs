using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ball : MonoBehaviour
{


    public int speed;  // speed of the ball
    void Start()
    {
        //shoots the ball 
        Rigidbody2D rd2d = GetComponent<Rigidbody2D>();
        Vector2 movement = new Vector2(1.0f, 1.0f);
        rd2d.AddForce(movement * speed);
    }


    void Update()
    {
        
    }

    // haven't used it but shoots the ball for maybe a reset
    public void ballStart()
    {
        Rigidbody2D rd2d = GetComponent<Rigidbody2D>();
        Vector2 movement = new Vector2(1.0f, 1.0f);
        rd2d.AddForce(movement * speed);
    }

    public void ballReset()
    {
        Transform ball = GameObject.Find("ball").GetComponent<Transform>();
        ball.transform.position = new Vector3(5.19F, -0.67F, 44);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class playerOne : MonoBehaviour
{
    //bounds of the player arena
    public float lowerBound;
    public float upperBound;

    //speed of the player
    public float speed;

    void Start()
    {
        
    }



    void Update()
    {


    }

    //moves the player
    private void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            transform.position += new Vector3(0, 1.0f * speed, 0);

        }
        if (Input.GetKey("s"))
        {
            transform.position += new Vector3(0, -1.0f * speed, 0);
        }

        //keeps the player from leaving the play arena
        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, lowerBound, upperBound));

    }
}
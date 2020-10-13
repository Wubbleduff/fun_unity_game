using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerTwo : MonoBehaviour
{
    // speed of the player
    public float speed;

    //boundries of the player arena
    public float lowerBound;
    public float upperBound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    //moves player
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0, 1.0f * speed, 0);

        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += new Vector3(0, -1.0f * speed, 0);
        }

        // keeps the pong from leaving the play area
        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, lowerBound, upperBound));
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class playerOne : MonoBehaviour
{

    public float lowerBound;
    public float upperBound;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {


    }

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

        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, lowerBound, upperBound));

    }
}
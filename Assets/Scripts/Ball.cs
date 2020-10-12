using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ball : MonoBehaviour
{
    // Start is called before the first frame update

    public int speed;
    void Start()
    {
        Rigidbody2D rd2d = GetComponent<Rigidbody2D>();
        Vector2 movement = new Vector2(1.0f, 1.0f);
        rd2d.AddForce(movement * speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerTwo : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {

            rb2d.transform.Translate(0, 1.0f * speed, 0);

        }
        if (Input.GetKey(KeyCode.DownArrow))
        {

            rb2d.transform.Translate(0, -1.0f * speed, 0);
        }
    }
}

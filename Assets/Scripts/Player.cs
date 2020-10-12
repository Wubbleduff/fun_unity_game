using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
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

        if (Input.GetAxis("Vertical") == 1)
        {

            rb2d.transform.Translate(0, 1.0f * speed, 0);

        }
        if(Input.GetAxis("Vertical") == -1)
        {

            rb2d.transform.Translate(0,-1.0f * speed, 0);
        }

    }
}

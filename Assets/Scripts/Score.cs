using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{


    public int playerOneScore;
    public int playerTwoScore;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("sup");
    }

    // Update is called once per frame
    void Update()
    {
        // check each wall for collsion with ball then score

        Collider2D eWall = GameObject.Find("eastWall").GetComponent<Collider2D>();
        Collider2D wWall = GameObject.Find("westWall").GetComponent<Collider2D>();

        if (eWall.IsTouching(GameObject.Find("ball").GetComponent<Collider2D>())) 
        {
            playerOneScore++;
            Debug.Log("player one score is" + playerOneScore);
            //reset();
        }
        if (wWall.IsTouching(GameObject.Find("ball").GetComponent<Collider2D>()))
        {
            playerTwoScore++;
            Debug.Log("player two score is" + playerTwoScore);
            //reset();
        }


        TextMeshProUGUI text = gameObject.GetComponent<TextMeshProUGUI>();
        if (text != null)
        {
            text.text = playerOneScore + " | " + playerTwoScore;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startOverButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void buttonPress()
    {
        GameObject.Find("Text score").GetComponent<Score>().resetGame();

        GameObject.Find("Text score").GetComponent<Score>().playerOneScore = 0;
        GameObject.Find("Text score").GetComponent<Score>().playerTwoScore = 0;
        GameObject.Find("Text score").GetComponent<Score>().isGameOver = false;

        GameObject.Find("ball").GetComponent<ball>().ballStart();

        GameObject.Find("startOverButton").SetActive(false);


    }

}

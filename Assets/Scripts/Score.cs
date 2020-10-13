using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{


    public int playerOneScore;
    public int playerTwoScore;

    public int gameOverScore;   // points till game over

    private bool isGameOver;    //the score from writing over the game over text


    void Start()
    {

    }

    void FixedUpdate()
    {
        // check each wall for collsion with ball then score

        Collider2D eWall = GameObject.Find("eastWall").GetComponent<Collider2D>();
        Collider2D wWall = GameObject.Find("westWall").GetComponent<Collider2D>();

        if (eWall.IsTouching(GameObject.Find("ball").GetComponent<Collider2D>())) 
        {
            playerOneScore++;

            // if player score is equal to gameover score end game if not reset the game
            if(playerOneScore == gameOverScore)
            {
                gameOver();
                isGameOver = true;
            }
            else
            {
                resetGame();
            }

        }
        if (wWall.IsTouching(GameObject.Find("ball").GetComponent<Collider2D>()))
        {
            playerTwoScore++;

            // if player score is equal to gameover score end game if not reset the game
            if (playerTwoScore == gameOverScore)
            {
                gameOver();
                isGameOver = true;
            }
            else
            {
                resetGame();
            }
        }

        //displays the score
        TextMeshProUGUI text = gameObject.GetComponent<TextMeshProUGUI>();
        if (isGameOver == false)
        {
            text.text = playerOneScore + " | " + playerTwoScore;
        }
    }

    // resets positive of game obejects
    void resetGame()
    {
        Transform playerOne = GameObject.Find("playerOne").GetComponent<Transform>();
        Transform playerTwo = GameObject.Find("playerTwo").GetComponent<Transform>();
        Transform ball = GameObject.Find("ball").GetComponent<Transform>();

        playerOne.transform.position = new Vector3(-24F, .59F, 44);
        playerTwo.transform.position = new Vector3(24.48F, .59F, 44);

        ball.transform.position = new Vector3(5.19F, -0.67F, 44);

    }

    // displays gameover text and haults movement
    void gameOver()
    {

        Rigidbody2D rball = GameObject.Find("ball").GetComponent<Rigidbody2D>();
        rball.velocity = new Vector2(0.0F, 0.0F); // stops ball

        //displays the right game over text
        TextMeshProUGUI text = gameObject.GetComponent<TextMeshProUGUI>();
        if (text != null)
        {

            if (playerOneScore == gameOverScore)
            {
                text.text = "Game Over player One Wins!";

            }
            else
            {
                text.text = "Game Over player Two Wins!";

            }
        }
    }
}

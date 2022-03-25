using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int player1Score;
    private int player2Score;
    public Ball ball;

    public void Player1Scores()
    {
        player1Score++;
        Debug.Log("Player 1 : " + player1Score);
        this.ball.ResetPosition();
    }

    public void Player2Scores()
    {
        player2Score++;
        Debug.Log("Player 2 : " + player2Score);

        this.ball.ResetPosition();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public Paddle PlayerPaddle;
    public Paddle ComputerPaddle;
    public Text PlayerScoreText;
    public Text ComputerscoreText;

    private int _playerScore;
    private int _computerScore;
    
    public void PlayerScores()
    {
        _playerScore++;
        this.PlayerScoreText.text = _playerScore.ToString();
        ResetRound();
    }

    public void Computerscores()
    {
        _computerScore++;
        this.ComputerscoreText.text = _computerScore.ToString();
        ResetRound();
    }

    private void ResetRound() {
        this.PlayerPaddle.ResetPosition();
        this.ComputerPaddle.ResetPosition();
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
    }
}

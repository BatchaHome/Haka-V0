using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndOfGame : MonoBehaviour
{
    public EndOfRound endOfRound;
    public SystemOfPoint systemOfPoint;

    public GameObject scoreBoard;

    public Text winnerText;

    public int finalPointPlayer1;
    public int finalPointPlayer2;
    public int finalPointPlayer3;

    public void EndOfTheGame()
    {
        WhoWonTheGame();
        ShowScoreboard();
    }

    public void WhoWonTheGame()
    {
        finalPointPlayer1 = systemOfPoint.player1Point[0] + systemOfPoint.player1Point[1] + systemOfPoint.player1Point[2] + systemOfPoint.player1Point[3] + systemOfPoint.player1Point[4];
        finalPointPlayer2 = systemOfPoint.player2Point[0] + systemOfPoint.player2Point[1] + systemOfPoint.player2Point[2] + systemOfPoint.player2Point[3] + systemOfPoint.player2Point[4];
        finalPointPlayer3 = systemOfPoint.player3Point[0] + systemOfPoint.player3Point[1] + systemOfPoint.player3Point[2] + systemOfPoint.player3Point[3] + systemOfPoint.player3Point[4];

        if (finalPointPlayer1 > finalPointPlayer2 && finalPointPlayer1 > finalPointPlayer3 && finalPointPlayer2 > finalPointPlayer3)
        {
            // 1 = P1
            // 2 = P2
            // 3 = P3

            winnerText.text = "First : Player1 (" + finalPointPlayer1 + ")\r\n";
            winnerText.text += "Second : Player2 (" + finalPointPlayer2 + ")\r\n";
            winnerText.text += "Third : Player3 (" + finalPointPlayer3 + ")";
        }
        else if (finalPointPlayer1 > finalPointPlayer2 && finalPointPlayer1 > finalPointPlayer3 && finalPointPlayer3 > finalPointPlayer2)
        {
            // 1 = P1
            // 2 = P3
            // 3 = P2

            winnerText.text = "First : Player1 (" + finalPointPlayer1 + ")\r\n";
            winnerText.text += "Second : Player3 (" + finalPointPlayer3 + ")\r\n";
            winnerText.text += "Third : Player2 (" + finalPointPlayer2 + ")";
        }
        else if (finalPointPlayer2 > finalPointPlayer1 && finalPointPlayer2 > finalPointPlayer3 && finalPointPlayer1 > finalPointPlayer3)
        {
            // 1 = P2
            // 2 = P1
            // 3 = P3

            winnerText.text = "First : Player2 (" + finalPointPlayer2 + ")\r\n";
            winnerText.text += "Second : Player1 (" + finalPointPlayer1 + ")\r\n";
            winnerText.text += "Third : Player3 (" + finalPointPlayer3 + ")";
        }
        else if (finalPointPlayer2 > finalPointPlayer1 && finalPointPlayer2 > finalPointPlayer3 && finalPointPlayer3 > finalPointPlayer1)
        {
            // 1 = P2
            // 2 = P3
            // 3 = P1

            winnerText.text = "First : Player2 (" + finalPointPlayer2 + ")\r\n";
            winnerText.text += "Second : Player3 (" + finalPointPlayer3 + ")\r\n";
            winnerText.text += "Third : Player1 (" + finalPointPlayer1 + ")";
        }
        else if (finalPointPlayer3 > finalPointPlayer2 && finalPointPlayer3 > finalPointPlayer1 && finalPointPlayer1 > finalPointPlayer2)
        {
            // 1 = P3
            // 2 = P1
            // 3 = P2

            winnerText.text = "First : Player3 (" + finalPointPlayer3 + ")\r\n";
            winnerText.text += "Second : Player1 (" + finalPointPlayer1 + ")\r\n";
            winnerText.text += "Third : Player2 (" + finalPointPlayer2 + ")";
        }
        else if (finalPointPlayer3 > finalPointPlayer2 && finalPointPlayer3 > finalPointPlayer1 && finalPointPlayer2 > finalPointPlayer1)
        {
            // 1 = P3
            // 2 = P2
            // 3 = P1

            winnerText.text = "First : Player3 (" + finalPointPlayer3 + ")\r\n";
            winnerText.text += "Second : Player2 (" + finalPointPlayer2 + ")\r\n";
            winnerText.text += "Third : Player1 (" + finalPointPlayer1 + ")";
        }
    }

    public void ShowScoreboard()
    {
        scoreBoard.GetComponent<Image>().color = new Color32(180, 180, 180, 255); 
    }
}

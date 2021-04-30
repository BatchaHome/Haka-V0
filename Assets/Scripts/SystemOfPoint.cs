using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SystemOfPoint : MonoBehaviour
{
    public EndOfRound endOfRound;

    public int[] player1Point;
    public int[] player2Point;
    public int[] player3Point;

    public GameObject player1AreaPoint;
    public GameObject player2AreaPoint;
    public GameObject player3AreaPoint;
    public GameObject player1CardStackWon;
    public GameObject player2CardStackWon;
    public GameObject player3CardStackWon;

    private int pointPlayer1 = 0;
    private int pointPlayer2 = 0;
    private int pointPlayer3 = 0;

    public void Awake()
    {
        player1Point = new int[5];
        player2Point = new int[5];
        player3Point = new int[5];
    }

    public void ComptingPoint()
    {
        foreach (Transform stack in player1CardStackWon.transform)
        {
            pointPlayer1++;
        }

        foreach (Transform stack in player2CardStackWon.transform)
        {
            pointPlayer2++;
        }

        foreach (Transform stack in player3CardStackWon.transform)
        {
            pointPlayer3++;
        }

        if (pointPlayer1 == 0)
        {
            pointPlayer1 = -2;
        }
        else if (pointPlayer2 == 0)
        {
            pointPlayer2 = -2;
        }
        else if (pointPlayer3 == 0)
        {
            pointPlayer3 = -2;
        }
    }

    public void AddPointIntoArray()
    {
        if (endOfRound.numberOfRound == 0)
        {
            player1Point[0] = pointPlayer1;
            player2Point[0] = pointPlayer2;
            player3Point[0] = pointPlayer3;
        }
        else if (endOfRound.numberOfRound == 1)
        {
            player1Point[1] = pointPlayer1;
            player2Point[1] = pointPlayer2;
            player3Point[1] = pointPlayer3;
        }
        else if (endOfRound.numberOfRound == 2)
        {
            player1Point[2] = pointPlayer1;
            player2Point[2] = pointPlayer2;
            player3Point[2] = pointPlayer3;
        }
        else if (endOfRound.numberOfRound == 3)
        {
            player1Point[3] = pointPlayer1;
            player2Point[3] = pointPlayer2;
            player3Point[3] = pointPlayer3;
        }
        else if (endOfRound.numberOfRound == 4)
        {
            player1Point[4] = pointPlayer1;
            player2Point[4] = pointPlayer2;
            player3Point[4] = pointPlayer3;
        }
        else
        {

        }
    }

    public void ShowPointToPlayer()
    {
        Text player1TextPoint = player1AreaPoint.GetComponentInChildren<Text>();
        player1TextPoint.text = (player1Point[0] + player1Point[1] + player1Point[2] + player1Point[3] + player1Point[4]).ToString();

        Text player2TextPoint = player2AreaPoint.GetComponentInChildren<Text>();
        player2TextPoint.text = (player2Point[0] + player2Point[1] + player2Point[2] + player2Point[3] + player2Point[4]).ToString();

        Text player3TextPoint = player3AreaPoint.GetComponentInChildren<Text>();
        player3TextPoint.text = (player3Point[0] + player3Point[1] + player3Point[2] + player3Point[3] + player3Point[4]).ToString();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndOfTurn : MonoBehaviour
{
    public TurnPlayer turnPlayer;
    public PlayerBegin playerBegin;
    public IsARedCard isARedCard;
    public Rules rules;

    public GameObject player1Area;
    public GameObject player2Area;
    public GameObject player3Area;

    public GameObject tableDropZone;
    public GameObject player1Hand;
    public GameObject player2Hand;
    public GameObject player3Hand;

    public GameObject player1CardStackWon;
    public GameObject player2CardStackWon;
    public GameObject player3CardStackWon;

    public int pointPlayer1;
    public int pointPlayer2;
    public int pointPlayer3;

    public bool isTurnReset = false;

    public void ResetForNewTurn()
    {  
        ResetPlayerHand();
        ResetCardOnTable();
        WhoBeginAfterTurn();
    }

    public void ResetPlayerHand()
    {
        foreach (GameObject card in turnPlayer.cardsInTable)
        {
            if (player1Hand.GetComponent<PlayerHand>().cardsInHand.Contains(card))
            {
                player1Hand.GetComponent<PlayerHand>().cardsInHand.Remove(card);
            }
            else if (player2Hand.GetComponent<PlayerHand>().cardsInHand.Contains(card))
            {
                player2Hand.GetComponent<PlayerHand>().cardsInHand.Remove(card);
            }
            else if (player3Hand.GetComponent<PlayerHand>().cardsInHand.Contains(card))
            {
                player3Hand.GetComponent<PlayerHand>().cardsInHand.Remove(card);
            }
        }
    }

    public void ResetCardOnTable()
    {
        turnPlayer.cardsInTable.Clear();
        isARedCard.isARedCardOnTable = false;

        rules.indexOfCards.Clear();

        for (int i = 0; i < tableDropZone.transform.childCount; i++)
        {
            Destroy(tableDropZone.transform.GetChild(i).gameObject);
        }
    }

    public void WhoBeginAfterTurn()
    {
        if (playerBegin.isPlayer1Begin)
        {
            playerBegin.isPlayer1Begin = false;
            playerBegin.isPlayer2Begin = true;
            playerBegin.isPlayer3Begin = false;

            turnPlayer.player1HasToPlay = false;
            turnPlayer.player2HasToPlay = true;
            turnPlayer.player3HasToPlay = false;

            Debug.Log("C'est le joueur 1 qui a commencé au tour precedent c'est donc au joueur 2 de commencer ce tour");
        }
        else if (playerBegin.isPlayer2Begin)
        {
            playerBegin.isPlayer1Begin = false;
            playerBegin.isPlayer2Begin = false;
            playerBegin.isPlayer3Begin = true;

            turnPlayer.player1HasToPlay = false;
            turnPlayer.player2HasToPlay = false;
            turnPlayer.player3HasToPlay = true;

            Debug.Log("C'est le joueur 2 qui a commencé au tour precedent c'est donc au joueur 3 de commencer ce tour");
        }
        else if (playerBegin.isPlayer3Begin)
        {
            playerBegin.isPlayer1Begin = true;
            playerBegin.isPlayer2Begin = false;
            playerBegin.isPlayer3Begin = false;

            turnPlayer.player1HasToPlay = true;
            turnPlayer.player2HasToPlay = false;
            turnPlayer.player3HasToPlay = false;

            Debug.Log("C'est le joueur 3 qui a commencé au tour precedent c'est donc au joueur 1 de commencer ce tour");
        }

        playerBegin.WhoPlayedAfterWho();
    }

    public void ComptingPoint()
    {
        foreach (GameObject stack in player1CardStackWon.transform)
        {
           pointPlayer1 = 0;
           pointPlayer1++;
        }

        foreach (GameObject stack in player2CardStackWon.transform)
        {
            pointPlayer2 = 0;
            pointPlayer2++;
        }

        foreach (GameObject stack in player3CardStackWon.transform)
        {
            pointPlayer3 = 0;
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

        Text textPointPlayer1 = player1CardStackWon.GetComponentInChildren<Text>();
        textPointPlayer1.text = textPointPlayer1.text;

        Text textPointPlayer2 = player2CardStackWon.GetComponentInChildren<Text>();
        textPointPlayer2.text = pointPlayer2.ToString();

        Text textPointPlayer3 = player3CardStackWon.GetComponentInChildren<Text>();
        textPointPlayer3.text = pointPlayer3.ToString();

    }
}

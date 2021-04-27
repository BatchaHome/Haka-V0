using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndOfTurn : MonoBehaviour
{
    public TurnPlayer turnPlayer;
    public PlayerBegin playerBegin;
    public IsARedCard isARedCard;

    public GameObject tableDropZone;
    public GameObject player1Hand;
    public GameObject player2Hand;
    public GameObject player3Hand;

    public bool isTurnReset = false;

    public void ResetForNewTurn()
    {
        isTurnReset = true;

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
        turnPlayer.enabled = false;
        isARedCard.isARedCardOnTable = false;

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
}

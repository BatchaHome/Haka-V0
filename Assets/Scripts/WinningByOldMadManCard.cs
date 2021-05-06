using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinningByOldMadManCard : MonoBehaviour
{
    public Rules rules;
    public CreatingCards creatingCards;
    public ListCardsTable listCardsTable;
    public DrawingCards drawingCards;
    public PlayerBegin playerBegin;
    public WinningStack winningStack;

    public GameObject player1Hand;
    public GameObject player2Hand;
    public GameObject player3Hand;

    public bool isPlayer1PlayedOMM = false;
    public bool isPlayer2PlayedOMM = false;
    public bool isPlayer3PlayedOMM = false;

    public void WhoWinsByOldMadManCard()
    {
        WhoPlayedAOMM();
        WhoWins();
    }

    public void WhoPlayedAOMM()
    {
        foreach (GameObject card in listCardsTable.cardsInTable)
        {
            if (player1Hand.GetComponent<PlayerHand>().cardsInHand.Contains(card) && creatingCards.cards.IndexOf(card) >= 17)
            {
                isPlayer1PlayedOMM = true;
                Debug.Log("Le joueur 1 a joué une carte Vieux fou");
            }
            else if (player2Hand.GetComponent<PlayerHand>().cardsInHand.Contains(card) && creatingCards.cards.IndexOf(card) >= 17)
            {
                isPlayer2PlayedOMM = true;
                Debug.Log("Le joueur 2 a joué une carte Vieux fou");
            }
            else if (player3Hand.GetComponent<PlayerHand>().cardsInHand.Contains(card) && creatingCards.cards.IndexOf(card) >= 17)
            {
                isPlayer3PlayedOMM = true;
                Debug.Log("Le joueur 3 a joué une carte Vieux fou");
            }
            else
            {
                isPlayer1PlayedOMM = false;
                isPlayer2PlayedOMM = false;
                isPlayer3PlayedOMM = false;
            }
        }
    }

    public void WhoWins()
    {
        if (isPlayer1PlayedOMM && isPlayer2PlayedOMM && isPlayer3PlayedOMM && playerBegin.player1PlaceInTurn > playerBegin.player2PlaceInTurn && playerBegin.player1PlaceInTurn > playerBegin.player3PlaceInTurn)
        {
            Debug.Log("P1 win bc put last OOM while P2 and P3 put one");
            winningStack.isPlayer1WonThisStack = true;
        }
        else if (isPlayer1PlayedOMM && isPlayer2PlayedOMM && playerBegin.player1PlaceInTurn > playerBegin.player2PlaceInTurn)
        {
            Debug.Log("P1 win bc put last OOM while P2 put one");
            winningStack.isPlayer1WonThisStack = true;
        }
        else if (isPlayer1PlayedOMM && isPlayer3PlayedOMM && playerBegin.player1PlaceInTurn > playerBegin.player3PlaceInTurn)
        {
            Debug.Log("P1 win bc put last OOM while P3 put one");
            winningStack.isPlayer1WonThisStack = true;
        }
        else if (isPlayer1PlayedOMM && isPlayer2PlayedOMM && isPlayer3PlayedOMM && playerBegin.player2PlaceInTurn > playerBegin.player1PlaceInTurn && playerBegin.player2PlaceInTurn > playerBegin.player3PlaceInTurn)
        {
            Debug.Log("P2 win bc put last OOM while P1 and P2 put one");
            winningStack.isPlayer2WonThisStack = true;
        }
        else if (isPlayer2PlayedOMM && isPlayer1PlayedOMM && playerBegin.player2PlaceInTurn > playerBegin.player1PlaceInTurn)
        {
            Debug.Log("P2 win bc put last OOM while P1 put one");
            winningStack.isPlayer2WonThisStack = true;
        }
        else if (isPlayer2PlayedOMM && isPlayer3PlayedOMM && playerBegin.player2PlaceInTurn > playerBegin.player3PlaceInTurn)
        {
            Debug.Log("P2 win bc put last OOM while P3 put one");
            winningStack.isPlayer2WonThisStack = true;
        }
        else if (isPlayer1PlayedOMM && isPlayer2PlayedOMM && isPlayer3PlayedOMM && playerBegin.player3PlaceInTurn > playerBegin.player1PlaceInTurn && playerBegin.player3PlaceInTurn > playerBegin.player2PlaceInTurn)
        {
            Debug.Log("P3 win bc put last OOM while P1 and P2 put one");
            winningStack.isPlayer3WonThisStack = true;
        }
        else if (isPlayer3PlayedOMM && isPlayer1PlayedOMM && playerBegin.player3PlaceInTurn > playerBegin.player1PlaceInTurn)
        {
            Debug.Log("P3 win bc put last OOM while P1 put one");
            winningStack.isPlayer3WonThisStack = true;
        }
        else if (isPlayer3PlayedOMM && isPlayer2PlayedOMM && playerBegin.player3PlaceInTurn > playerBegin.player2PlaceInTurn)
        {
            Debug.Log("P3 win bc put last OOM while P2 put one");
            winningStack.isPlayer3WonThisStack = true;
        }
    }


}

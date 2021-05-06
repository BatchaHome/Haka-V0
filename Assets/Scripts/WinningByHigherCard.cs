using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinningByHigherCard : MonoBehaviour
{
    public ListCardsTable listCardsTable;
    public CreatingCards creatingCards;
    public DrawingCards drawingCards;
    public Rules rules;
    public WinningStack winningStack;

    public GameObject player1Hand;
    public GameObject player2Hand;
    public GameObject player3Hand;

    public int cardWinning;

    public void WhoWinsByHigherCard()
    {
        if (rules.indexOfCards[0] >= 17)
        {
            rules.indexOfCards[0] = 0;
        }
        else if (rules.indexOfCards[1] >= 17)
        {
            rules.indexOfCards[1] = 0;
        }
        else if (rules.indexOfCards[2] >= 17)
        {
            rules.indexOfCards[2] = 0;
        }

        if (rules.indexOfCards[0] > rules.indexOfCards[1] && rules.indexOfCards[0] > rules.indexOfCards[2])
        {
            cardWinning = rules.indexOfCards[0];
        }
        else if (rules.indexOfCards[1] > rules.indexOfCards[2] && rules.indexOfCards[1] > rules.indexOfCards[0])
        {
            cardWinning = rules.indexOfCards[1];
        }
        else if (rules.indexOfCards[2] > rules.indexOfCards[0] && rules.indexOfCards[2] > rules.indexOfCards[1])
        {
            cardWinning = rules.indexOfCards[2];
        }

        foreach (GameObject card in listCardsTable.cardsInTable)
        {
            if (card == creatingCards.cards[cardWinning])
            {
                if (player1Hand.GetComponent<PlayerHand>().cardsInHand.Contains(card))
                {
                    winningStack.isPlayer1WonThisStack = true;
                }
                else if (player2Hand.GetComponent<PlayerHand>().cardsInHand.Contains(card))
                {
                    winningStack.isPlayer2WonThisStack = true;
                }
                else if (player3Hand.GetComponent<PlayerHand>().cardsInHand.Contains(card))
                {
                    winningStack.isPlayer3WonThisStack = true;
                    
                }
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinningByHigherCard : MonoBehaviour
{
    public TurnPlayer turnPlayer;
    public CreatingCards creatingCards;
    public DrawingCards drawingCards;
    public Rules rules;
    public WinningStack winningStack;

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

        foreach (GameObject card in turnPlayer.cardsInTable)
        {
            if (card == creatingCards.cards[cardWinning])
            {
                if (drawingCards.player1Cards.Contains(card))
                {
                    winningStack.isPlayer1WonThisStack = true;
                }
                else if (drawingCards.player2Cards.Contains(card))
                {
                    winningStack.isPlayer2WonThisStack = true;
                }
                else if (drawingCards.player3Cards.Contains(card))
                {
                    winningStack.isPlayer3WonThisStack = true;
                    
                }
            }
        }
    }
}

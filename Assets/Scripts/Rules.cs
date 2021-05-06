using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rules : MonoBehaviour
{
    public TurnPlayer turnPlayer;
    public CreatingCards creatingCards;
    public WinningStack winningStack;
    public ListCardsTable listCardsTable;

    public WinningByHigherCard winningByHigherCard;
    public WinningByOldMadManCard winningByOldMadManCard;

    public List<int> indexOfCards = new List<int>();    

    public bool everyonePlayed = false;
    public bool isTwoOldMadManHaveBeenPlayed = false;


    public void EndTurnOfTheTable()
    {
        if (turnPlayer.player1HavePlayedThisTurn && turnPlayer.player2HavePlayedThisTurn && turnPlayer.player3HavePlayedThisTurn)
        {
            Debug.Log("Tous les joueurs ont jou� ce tour de table");
            turnPlayer.player1HavePlayedThisTurn = false;
            turnPlayer.player2HavePlayedThisTurn = false;
            turnPlayer.player3HavePlayedThisTurn = false;

            everyonePlayed = true;
        }
    }

    public void WhoWinThisTurn()
    {
        foreach (GameObject card in listCardsTable.cardsInTable)
        {
            int indexOfCard = creatingCards.cards.IndexOf(card);
            indexOfCards.Add(indexOfCard);
        }

        if (indexOfCards[0] >= 17 && indexOfCards[1] >= 17 || indexOfCards[0] >= 17 && indexOfCards[2] >= 17 || indexOfCards[1] >= 17 && indexOfCards[2] >= 17 || indexOfCards[1] >= 17 && indexOfCards[0] >= 17 || indexOfCards[2] >= 17 && indexOfCards[0] >= 17 || indexOfCards[2] >= 17 && indexOfCards[1] >= 17)
        {
            isTwoOldMadManHaveBeenPlayed = true;
            Debug.Log("Deux cartes Vieux Fou ont �t� jou�es");
        }
        else
        {
            isTwoOldMadManHaveBeenPlayed = false;
        }

        if (isTwoOldMadManHaveBeenPlayed)
        {
            winningByOldMadManCard.WhoWinsByOldMadManCard();
        }
        else
        {
            winningByHigherCard.WhoWinsByHigherCard();
        }

        if (winningStack.isPlayer1WonThisStack || winningStack.isPlayer2WonThisStack || winningStack.isPlayer3WonThisStack)
        {
            winningStack.WinnerOfThisStack();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsARedCard : MonoBehaviour
{
    public GameObject table;
    public TurnPlayer turnPlayer;
    public CreatingCards creatingCards;

    public bool isARedCardOnTable;

    public void RedCardOnTable()
    {
        foreach (GameObject card in turnPlayer.cardsInTable)
        {
            int indexOfCard = creatingCards.cards.IndexOf(card);

            if (indexOfCard >= 8)
            {
                isARedCardOnTable = true;
            }
            else
            {
                isARedCardOnTable = false;
            }
        }
    }
}

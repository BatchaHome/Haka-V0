using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndOfTurn : MonoBehaviour
{
    public TurnPlayer turnPlayer;

    public GameObject table;
    public GameObject player1Hand;
    public GameObject player2Hand;
    public GameObject player3Hand;

    public void ResetForNewTurn()
    {
        ResetPlayerHand();
        ResetCardOnTable();
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

        for (int i = 0; i < table.transform.childCount; i++)
        {
            Destroy(table.transform.GetChild(i).gameObject);
        }
    }
}

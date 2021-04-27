using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArePlayersHaveRedCards : MonoBehaviour
{
    public CreatingCards creatingCards;
    public PlayerHand playerHand;
    public TurnPlayer turnPlayer;

    public GameObject player1Hand;
    public GameObject player2Hand;
    public GameObject player3Hand;

    public bool isPlayerHasRedCards;

    public void PlayerHasRedCardsInHand()
    {
        if (turnPlayer.player1HasToPlay)
        {
            foreach (GameObject card in player1Hand.GetComponent<PlayerHand>().cardsInHand)
            {
                if (creatingCards.cards.IndexOf(card) > 7)
                {
                    isPlayerHasRedCards = true;
                }
            }
        }
        else if (turnPlayer.player2HasToPlay)
        {
            foreach (GameObject card in player2Hand.GetComponent<PlayerHand>().cardsInHand)
            {
                if (creatingCards.cards.IndexOf(card) > 7)
                {
                    isPlayerHasRedCards = true;
                }
            }
        }
        else if (turnPlayer.player3HasToPlay)
        {
            foreach (GameObject card in player3Hand.GetComponent<PlayerHand>().cardsInHand)
            {
                if (creatingCards.cards.IndexOf(card) > 7)
                {
                    isPlayerHasRedCards = true;
                }
            }
        }
        else
        {
            Debug.Log("Something went wrong ...");
        }
    }
}

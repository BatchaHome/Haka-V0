using UnityEngine;

public class ArePlayersHaveRedCards : MonoBehaviour
{
    public CreatingCards creatingCards;
    public TurnPlayer turnPlayer;

    public GameObject player1Hand;
    public GameObject player2Hand;
    public GameObject player3Hand;

    public bool isPlayer1HasRedCards;
    public bool isPlayer2HasRedCards;
    public bool isPlayer3HasRedCards;

    public void Update()
    {
        if (turnPlayer.player1HasToPlay)
        {
            foreach (GameObject card in player1Hand.GetComponent<PlayerHand>().cardsInHand)
            {
                if (creatingCards.cards.IndexOf(card) > 7)
                {
                    isPlayer1HasRedCards = true;
                    break;
                }
                else
                {
                    isPlayer1HasRedCards = false;
                }
            }
        }
        else if (turnPlayer.player2HasToPlay)
        {
            foreach (GameObject card in player2Hand.GetComponent<PlayerHand>().cardsInHand)
            {
                if (creatingCards.cards.IndexOf(card) > 7)
                {
                    isPlayer2HasRedCards = true;
                    break;
                }
                else
                {
                    isPlayer2HasRedCards = false;
                }
            }
        }
        else if (turnPlayer.player3HasToPlay)
        {
            foreach (GameObject card in player3Hand.GetComponent<PlayerHand>().cardsInHand)
            {
                if (creatingCards.cards.IndexOf(card) > 7)
                {
                    isPlayer3HasRedCards = true;
                    break;
                }
                else
                {
                    isPlayer3HasRedCards = false;
                }
            }
        }
        else
        {
            Debug.Log("Something went wrong ...");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawingCards : MonoBehaviour
{

    public GameObject player1Hand;
    public GameObject player2Hand;
    public GameObject player3Hand;
    public GameObject deck;
    public GameObject goze;

    public CreatingCards creatingCards;
    
    public void DrawingCard()
    {
        foreach (GameObject card in creatingCards.cards)
        {
            GameObject picked;
            picked = deck.transform.GetChild(Random.Range(0, deck.transform.childCount)).gameObject;

            if (player1Hand.transform.childCount < player2Hand.transform.childCount && player1Hand.transform.childCount < 5)
            {
                picked.transform.SetParent(player1Hand.transform, false);
                Debug.Log("Carte distribué à player 1");

                player1Hand.GetComponent<PlayerHand>().cardsInHand.Add(picked);
            }
            else if (player2Hand.transform.childCount < player3Hand.transform.childCount && player2Hand.transform.childCount < 5)
            {
                picked.transform.SetParent(player2Hand.transform, false);
                Debug.Log("Carte distribué à player 2");

                player2Hand.GetComponent<PlayerHand>().cardsInHand.Add(picked);
            }
            else if (player3Hand.transform.childCount < goze.transform.childCount && player3Hand.transform.childCount < 5)
            {
                picked.transform.SetParent(player3Hand.transform, false);
                Debug.Log("Carte distribué à player 3");

                player3Hand.GetComponent<PlayerHand>().cardsInHand.Add(picked);
            }
            else if (goze.transform.childCount < 5)
            {
                picked.transform.SetParent(goze.transform, false);
                Debug.Log("Carte distribué à goze");
                picked.GetComponent<DragAndDrop>().enabled = false;

                goze.GetComponent<ListCardsGoze>().cardsInGoze.Add(picked);
            }
        }
    }
}

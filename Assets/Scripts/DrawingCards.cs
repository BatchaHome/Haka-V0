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

    private bool isAllCardDrawed = false;

    public List<GameObject> player1Cards = new List<GameObject>();
    public List<GameObject> player2Cards = new List<GameObject>();
    public List<GameObject> player3Cards = new List<GameObject>();
    public List<GameObject> gozeCards = new List<GameObject>();
    
    public void DrawingCard()
    {
        if (!isAllCardDrawed)
        {
            foreach (GameObject card in creatingCards.cards)
            {
                GameObject picked;
                picked = deck.transform.GetChild(Random.Range(0, deck.transform.childCount)).gameObject;

                if (player1Hand.transform.childCount < player2Hand.transform.childCount && player1Hand.transform.childCount < 5)
                {
                    picked.transform.SetParent(player1Hand.transform, false);
                    Debug.Log("Carte distribué à player 1");

                    player1Cards.Add(picked);
                    player1Hand.GetComponent<PlayerHand>().cardsInHand.Add(picked);
                }
                else if (player2Hand.transform.childCount < player3Hand.transform.childCount && player2Hand.transform.childCount < 5)
                {
                    picked.transform.SetParent(player2Hand.transform, false);
                    Debug.Log("Carte distribué à player 2");

                    player2Cards.Add(picked);
                    player2Hand.GetComponent<PlayerHand>().cardsInHand.Add(picked);
                }
                else if (player3Hand.transform.childCount < goze.transform.childCount && player3Hand.transform.childCount < 5)
                {
                    picked.transform.SetParent(player3Hand.transform, false);
                    Debug.Log("Carte distribué à player 3");

                    player3Cards.Add(picked);
                    player3Hand.GetComponent<PlayerHand>().cardsInHand.Add(picked);
                }
                else if (goze.transform.childCount < 5)
                {
                    picked.transform.SetParent(goze.transform, false);
                    Debug.Log("Carte distribué à goze");
                    picked.GetComponent<BoxCollider2D>().enabled = false;

                    gozeCards.Add(picked);
                }

                if (player1Hand.transform.childCount == 5 && player2Hand.transform.childCount == 5 && player3Hand.transform.childCount == 5 && goze.transform.childCount == 5)
                {
                    isAllCardDrawed = true;
                }
            }
        }
        else
        {
            isAllCardDrawed = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetForNewRound : MonoBehaviour
{
    public GameObject goze;
    public GameObject deck;
    public GameObject player1CardStackWon;
    public GameObject player2CardStackWon;
    public GameObject player3CardStackWon;
    public GameObject player1Hand;
    public GameObject player2Hand;
    public GameObject player3Hand;

    public DrawingCards drawingCards;
    public CreatingCards creatingCards;
    public WinningStack winningStack;
    public CardInDeck cardInDeck;

    private bool isAllCardsDrawed;
    public void ResetDrawingCards()
    {
        PutEveryCardInDeck();
        DrawingCardsAfterRound();
        
    }

    public void PutEveryCardInDeck()
    {
        foreach (GameObject cardInGoze in drawingCards.gozeCards)
        { 
            cardInGoze.transform.SetParent(deck.transform, true);

            cardInDeck.cardInDeck.Add(cardInGoze);
        }


            foreach (GameObject cardInPlayer1Stack in winningStack.player1StackWon)
            {
                cardInPlayer1Stack.transform.SetParent(deck.transform, true);
                cardInDeck.cardInDeck.Add(cardInPlayer1Stack);
            }
     
      
            foreach (GameObject cardInPlayer2Stack in winningStack.player2StackWon)
            {
                cardInPlayer2Stack.transform.SetParent(deck.transform, true);
                cardInDeck.cardInDeck.Add(cardInPlayer2Stack);
            }
       
  
            foreach (GameObject cardInPlayer3Stack in winningStack.player3StackWon)
            {
                cardInPlayer3Stack.transform.SetParent(deck.transform, true);
                cardInDeck.cardInDeck.Add(cardInPlayer3Stack);
            }
        
    }

    public void DrawingCardsAfterRound()
    {
        if (!isAllCardsDrawed)
        {
            foreach (GameObject card in cardInDeck.cardInDeck)
            {
                Debug.Log(deck.transform.childCount.ToString());

                GameObject picked;
                picked = deck.transform.GetChild(Random.Range(0, deck.transform.childCount)).gameObject;

                if (player1Hand.transform.childCount < player2Hand.transform.childCount && player1Hand.transform.childCount <= 5)
                {
                    picked.transform.SetParent(player1Hand.transform, false);
                    Debug.Log("Carte distribué à player 1");

                    drawingCards.player1Cards.Add(picked);
                    player1Hand.GetComponent<PlayerHand>().cardsInHand.Add(picked);
                }
                else if (player2Hand.transform.childCount < player3Hand.transform.childCount && player2Hand.transform.childCount <= 5)
                {
                    picked.transform.SetParent(player2Hand.transform, false);
                    Debug.Log("Carte distribué à player 2");

                    drawingCards.player2Cards.Add(picked);
                    player2Hand.GetComponent<PlayerHand>().cardsInHand.Add(picked);
                }
                else if (player3Hand.transform.childCount < goze.transform.childCount && player3Hand.transform.childCount <= 5)
                {
                    picked.transform.SetParent(player3Hand.transform, false);
                    Debug.Log("Carte distribué à player 3");

                    drawingCards.player3Cards.Add(picked);
                    player3Hand.GetComponent<PlayerHand>().cardsInHand.Add(picked);
                }
                else if (goze.transform.childCount <= 5)
                {
                    picked.transform.SetParent(goze.transform, false);
                    Debug.Log("Carte distribué à goze");

                    drawingCards.gozeCards.Add(picked);
                }
                else
                {
                    Debug.Log("Something went wrong with drawing...");
                }

                if (player1Hand.transform.childCount == 5 && player2Hand.transform.childCount == 5 && player3Hand.transform.childCount == 5 && goze.transform.childCount == 5)
                {
                    isAllCardsDrawed = true;
                    cardInDeck.cardInDeck.Clear();
                }
            }
        }
        else
        {
            isAllCardsDrawed = false;
        }
    }
}

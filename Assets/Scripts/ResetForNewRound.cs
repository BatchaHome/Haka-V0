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
    public ListCardsDeck listCardsDeck;
    public EndOfRound endOfRound;

    public void ResetDrawingCards()
    {
        PutEveryCardInDeck();
        ResetList();
        drawingCards.DrawingCard();
    }

    public void ResetList()
    {
        goze.GetComponent<ListCardsGoze>().cardsInGoze.Clear();

        player1CardStackWon.GetComponent<ListStackPlayer>().stackWon.Clear();
        player2CardStackWon.GetComponent<ListStackPlayer>().stackWon.Clear();
        player3CardStackWon.GetComponent<ListStackPlayer>().stackWon.Clear();
    }

    public void PutEveryCardInDeck()
    {
        foreach (GameObject cardInGoze in goze.GetComponent<ListCardsGoze>().cardsInGoze)
        {
            cardInGoze.transform.SetParent(deck.transform, false);
            listCardsDeck.cardsInDeck.Add(cardInGoze);

            Debug.Log("Put card in deck from goze");
        }

        foreach (GameObject cardInPlayer1Stack in player1CardStackWon.GetComponent<ListStackPlayer>().stackWon)
        {
            cardInPlayer1Stack.transform.SetParent(deck.transform, true);
            listCardsDeck.cardsInDeck.Add(cardInPlayer1Stack);

            Debug.Log("Put card in deck from StackPlayer1");
        }
     
      
        foreach (GameObject cardInPlayer2Stack in player2CardStackWon.GetComponent<ListStackPlayer>().stackWon)
        {
            cardInPlayer2Stack.transform.SetParent(deck.transform, true);
            listCardsDeck.cardsInDeck.Add(cardInPlayer2Stack);

            Debug.Log("Put card in deck from StackPlayer2");
        }
       
  
        foreach (GameObject cardInPlayer3Stack in player3CardStackWon.GetComponent<ListStackPlayer>().stackWon)
        {
            cardInPlayer3Stack.transform.SetParent(deck.transform, true);
            listCardsDeck.cardsInDeck.Add(cardInPlayer3Stack);

            Debug.Log("Put card in deck from StackPlayer3");
        }
        
    }
}

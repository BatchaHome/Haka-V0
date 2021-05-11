using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinningStack : MonoBehaviour
{
    public ListCardsTable listCardsTable;
    public ListCardsDeck listCardsDeck;

    public GameObject deck;

    public GameObject player1Hand;
    public GameObject player2Hand;
    public GameObject player3Hand;

    public GameObject player1CardStackWon;
    public GameObject player2CardStackWon;
    public GameObject player3CardStackWon;

    public bool isPlayer1WonThisStack = false;
    public bool isPlayer2WonThisStack = false;
    public bool isPlayer3WonThisStack = false;

    public void WinnerOfThisStack()
    {
        if (isPlayer1WonThisStack)
        {
            foreach (GameObject card in listCardsTable.cardsInTable)
            {
                player1CardStackWon.GetComponent<ListStackPlayer>().stackWon.Add(card);
                Debug.Log("Le joueur 1 a gagné ce pli");
                card.transform.SetParent(player1CardStackWon.transform, true);
                    
                card.transform.position = player1CardStackWon.transform.position;

            }
        }
        else if (isPlayer2WonThisStack)
        {
            foreach (GameObject card in listCardsTable.cardsInTable)
            {
                player2CardStackWon.GetComponent<ListStackPlayer>().stackWon.Add(card);
                Debug.Log("Le joueur 2 a gagné ce pli");
                card.transform.SetParent(player2CardStackWon.transform, true);

                card.transform.position = player2CardStackWon.transform.position;
            }
        }
        else if (isPlayer3WonThisStack)
        {
            foreach (GameObject card in listCardsTable.cardsInTable)
            {
                player3CardStackWon.GetComponent<ListStackPlayer>().stackWon.Add(card);
                Debug.Log("Le joueur 3 a gagné ce pli");
                card.transform.SetParent(player3CardStackWon.transform, true);
                  
                card.transform.position = player3CardStackWon.transform.position;
            }
        }
    }
 }

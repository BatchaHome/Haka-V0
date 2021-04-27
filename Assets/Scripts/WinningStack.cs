using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinningStack : MonoBehaviour
{
    public TurnPlayer turnPlayer;

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
            foreach (GameObject card in turnPlayer.cardsInTable)
            {
                if (player1Hand.GetComponent<PlayerHand>().cardsInHand.Contains(card))
                {
                    
                    Debug.Log("La carte va dans p1");
                    card.transform.SetParent(player1CardStackWon.transform, true);

                    card.transform.position = player1CardStackWon.transform.position;
                }
            }
        }
        else if (isPlayer2WonThisStack)
        {
            foreach (GameObject card in turnPlayer.cardsInTable)
            {
                if (player2Hand.GetComponent<PlayerHand>().cardsInHand.Contains(card))
                {
                    

                    Debug.Log("La carte va dans p2");
                    card.transform.SetParent(player2CardStackWon.transform, true);

                    card.transform.position = player2CardStackWon.transform.position;
                }
            }
        }
        else if (isPlayer3WonThisStack)
        {
            foreach (GameObject card in turnPlayer.cardsInTable)
            {
                if (player3Hand.GetComponent<PlayerHand>().cardsInHand.Contains(card))
                {
                    

                    Debug.Log("La carte va dans p3");
                    card.transform.SetParent(player3CardStackWon.transform, true);

                    card.transform.position = player3CardStackWon.transform.position;
                }
            }
        }
    }
 }

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public CreatingCards creatingCards;
    public DrawingCards drawingCards;
    public PlayerBegin playerBegin;
    public EndOfTurn endOfTurn;


    void Start()
    {
        creatingCards.CreatePeopleCards();
        creatingCards.CreateSamouraiCards();
        creatingCards.CreateOldMadManCards();
        drawingCards.DrawingCard();
        playerBegin.WhoBegin();

        endOfTurn.turnOfTable = 0;
    }
}

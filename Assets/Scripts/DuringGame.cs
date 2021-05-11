using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DuringGame : MonoBehaviour
{
    public EndOfRound endOfRound;
    public SystemOfPoint systemOfPoint;
    public ResetForNewRound resetForNewRound;
    public EndOfGame endOfGame;
    public EndOfTurn endOfTurn;

    public GameObject textTurnOfTable;
    public GameObject textRound;

    void Update()
    {
        ShowTurn();
        ShowRound();

        if (endOfRound.isEndOfTheRound && endOfRound.numberOfRound == 5)
        {
            endOfGame.EndOfTheGame();
        }
        else if (endOfRound.isEndOfTheRound)
        {
            systemOfPoint.ComptingPoint();
            systemOfPoint.AddPointIntoArray();
            systemOfPoint.ShowPointToPlayer();
            resetForNewRound.ResetDrawingCards();

            endOfRound.numberOfRound++;

            endOfRound.isEndOfTheRound = false;
        }
    }

    public void ShowTurn()
    {
        Text textInfoTurn = textTurnOfTable.GetComponent<Text>();
        textInfoTurn.text = "Turn of table :" + endOfTurn.turnOfTable;
    }

    public void ShowRound()
    {
        Text textInfoRound = textRound.GetComponent<Text>();
        textInfoRound.text = "Round :" + endOfRound.numberOfRound;
    }
}

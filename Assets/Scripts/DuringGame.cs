using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DuringGame : MonoBehaviour
{
    public EndOfRound endOfRound;
    public SystemOfPoint systemOfPoint;
    public ResetForNewRound resetForNewRound;

    void Update()
    {
        if (endOfRound.isEndOfTheRound)
        {
            systemOfPoint.ComptingPoint();
            systemOfPoint.AddPointIntoArray();
            systemOfPoint.ShowPointToPlayer();
            resetForNewRound.ResetDrawingCards();

            endOfRound.numberOfRound++;

            endOfRound.isEndOfTheRound = false;
        }
    }
}

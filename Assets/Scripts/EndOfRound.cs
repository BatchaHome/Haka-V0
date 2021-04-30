using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndOfRound : MonoBehaviour
{
    public EndOfTurn endOfTurn;

    public bool isEndOfTheRound = false;
    public int numberOfRound = 0;

    public void Update()
    {
        IsEndOfRound();
    }

    public void IsEndOfRound()
    {
        if (endOfTurn.turnOfTable == 5)
        {
            isEndOfTheRound = true;
            endOfTurn.turnOfTable = 0;
        }
    }
}

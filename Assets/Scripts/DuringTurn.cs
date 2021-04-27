using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuringTurn : MonoBehaviour
{
    public EndOfTurn endOfTurn;
    public CanPlay canPlay;
    public Rules rules;

    void Update()
    {
        canPlay.WhoCanPlay();
        rules.EndTurnOfTheTable();
        
        if (rules.everyonePlayed)
        {
            rules.WhoWinThisTurn();
            rules.everyonePlayed = false;

            endOfTurn.ResetForNewTurn();
        }
    }
}

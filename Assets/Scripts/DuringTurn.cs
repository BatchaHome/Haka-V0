using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuringTurn : MonoBehaviour
{
    public ArePlayersHaveRedCards arePlayer1HaveRedCards;
    public ArePlayersHaveRedCards arePlayer2HaveRedCards;
    public ArePlayersHaveRedCards arePlayer3HaveRedCards;
    public EndOfTurn endOfTurn;
    public CanPlay canPlay;
    public Rules rules;
    public TurnPlayer turnPlayer;
    public WinningStack winningStack;

    void Update()
    {
        canPlay.WhoCanPlay();
        rules.EndTurnOfTheTable();

        if (turnPlayer.player1HasToPlay)
        {
            arePlayer1HaveRedCards.PlayerHasRedCardsInHand();
        }
        else if (turnPlayer.player2HasToPlay)
        {
            arePlayer2HaveRedCards.PlayerHasRedCardsInHand();
        }
        else if (turnPlayer.player3HasToPlay)
        {
            arePlayer3HaveRedCards.PlayerHasRedCardsInHand();
        }
       
        if (rules.everyonePlayed)
        {
            rules.WhoWinThisTurn();
            rules.everyonePlayed = false;
        }

        if (winningStack.isPlayer1WonThisStack || winningStack.isPlayer2WonThisStack || winningStack.isPlayer3WonThisStack)
        {
            endOfTurn.ResetForNewTurn();

            turnPlayer.player1HavePlayed = false;
            turnPlayer.player2HavePlayed = false;
            turnPlayer.player3HavePlayed = false;

            winningStack.isPlayer1WonThisStack = false;
            winningStack.isPlayer2WonThisStack = false;
            winningStack.isPlayer3WonThisStack = false;
        }
    }
}

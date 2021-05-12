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
       
        if (rules.everyonePlayed)
        {
            rules.WhoWinThisTurn();
            
        }

        if (winningStack.isPlayer1WonThisStack || winningStack.isPlayer2WonThisStack || winningStack.isPlayer3WonThisStack)
        {
            endOfTurn.ResetForNewTurn();

            rules.everyonePlayed = false;

            turnPlayer.player1HavePlayed = false;
            turnPlayer.player2HavePlayed = false;
            turnPlayer.player3HavePlayed = false;

            winningStack.isPlayer1WonThisStack = false;
            winningStack.isPlayer2WonThisStack = false;
            winningStack.isPlayer3WonThisStack = false;
        }
    }
}

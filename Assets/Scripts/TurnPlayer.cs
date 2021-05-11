using UnityEngine;
using UnityEngine.UI;

public class TurnPlayer : MonoBehaviour
{
    public GameObject player1Hand;
    public GameObject player2Hand;
    public GameObject player3Hand;

    public bool player1HasToPlay = false;
    public bool player2HasToPlay = false;
    public bool player3HasToPlay = false;

    public bool player1HavePlayed = false;
    public bool player2HavePlayed = false;
    public bool player3HavePlayed = false;

    public bool player1HavePlayedThisTurn = false;
    public bool player2HavePlayedThisTurn = false;
    public bool player3HavePlayedThisTurn = false;

    public void SystemTurnPlayer()
    {
        if (player1HasToPlay)
        {
            player1HasToPlay = false;
            player2HasToPlay = true;
        }
        else if (player2HasToPlay)
        {
            player2HasToPlay = false;
            player3HasToPlay = true;
        }
        else if (player3HasToPlay)
        {
            player3HasToPlay = false;
            player1HasToPlay = true;
        }

        if (player1HavePlayed)
        {
            player1HavePlayed = false;
            player1HavePlayedThisTurn = true;
            Debug.Log("Le joueur 1 a joué, c'est au joueur 2 de jouer");
        }
        else if (player2HavePlayed)
        {
            player2HavePlayed = false;
            player2HavePlayedThisTurn = true;
            Debug.Log("Le joueur 2 a joué, c'est au joueur 3 de jouer");
        }
        else if (player3HavePlayed)
        {
            player3HavePlayed = false;
            player3HavePlayedThisTurn = true;
            Debug.Log("Le joueur 3 a joué, c'est au joueur 1 de joueur");
        }
    }
}

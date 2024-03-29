using UnityEngine;
using UnityEngine.UI;

public class PlayerBegin: MonoBehaviour
{
    public TurnPlayer turnPlayer;

    public GameObject player1Area;
    public GameObject player2Area;
    public GameObject player3Area;

    public bool isPlayer1Begin = false;
    public bool isPlayer2Begin = false;
    public bool isPlayer3Begin = false;

    public int player1PlaceInTurn;
    public int player2PlaceInTurn;
    public int player3PlaceInTurn;
    

    public void WhoBegin()
    {
        int indexOfPlayer = Random.Range(1, 4);

        if (indexOfPlayer == 1)
        {
            isPlayer1Begin = true;
            turnPlayer.player1HasToPlay = true;

            Debug.Log("C'est le joueur 1 qui commence");            
        }
        else if (indexOfPlayer == 2)
        {
            isPlayer2Begin = true;
            turnPlayer.player2HasToPlay = true;

            Debug.Log("C'est le joueur 2 qui commence");
        }
        else if (indexOfPlayer == 3)
        {
            isPlayer3Begin = true;
            turnPlayer.player3HasToPlay = true;

            Debug.Log("C'est le joueur 3 qui commence");
        }

        WhoPlayedAfterWho();
    }

    public void WhoPlayedAfterWho()
    {
        if (isPlayer1Begin)
        {
            player1PlaceInTurn = 1;
            player2PlaceInTurn = 2;
            player3PlaceInTurn = 3;
        }
        else if (isPlayer2Begin) {
            player2PlaceInTurn = 1;
            player3PlaceInTurn = 2;
            player1PlaceInTurn = 3;
        }
        else if (isPlayer3Begin)
        {
            player3PlaceInTurn = 1;
            player1PlaceInTurn = 2;
            player2PlaceInTurn = 3;
        }
    }
}

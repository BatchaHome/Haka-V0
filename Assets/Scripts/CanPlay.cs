using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanPlay : MonoBehaviour
{
    public PlayerBegin playerBegin;
    public TurnPlayer turnPlayer;

    public GameObject player1Hand;
    public GameObject player2Hand;
    public GameObject player3Hand;
    
    public void WhoCanPlay()
    {

        if (turnPlayer.player1HasToPlay)
        {
            for (int i = 0; i < player1Hand.transform.childCount; i++)
            {
                player1Hand.transform.GetChild(i).GetComponent<DragAndDrop>().enabled = true;
            }
        }
        else if (turnPlayer.player2HasToPlay)
        {
            for (int i = 0; i < player2Hand.transform.childCount; i++)
            {
                player2Hand.transform.GetChild(i).GetComponent<DragAndDrop>().enabled = true;
            }           
        } 
        else if (turnPlayer.player3HasToPlay)
        {
            for (int i = 0; i < player3Hand.transform.childCount; i++)
            {
                player3Hand.transform.GetChild(i).GetComponent<DragAndDrop>().enabled = true;
            }
        }
    }
}


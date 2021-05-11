using UnityEngine;
using UnityEngine.UI;

public class CanPlay : MonoBehaviour
{
    public PlayerBegin playerBegin;
    public TurnPlayer turnPlayer;

    public GameObject player1Hand;
    public GameObject player2Hand;
    public GameObject player3Hand;

    public GameObject player1Area;
    public GameObject player2Area;
    public GameObject player3Area;

    public Color canPlay = new Color32(105, 204, 97, 255);
    public Color cannotPlay = new Color32(123, 123, 123, 123);

    public void WhoCanPlay()
    {

        if (turnPlayer.player1HasToPlay)
        {
            player1Area.GetComponent<Image>().color = canPlay;
            player2Area.GetComponent<Image>().color = cannotPlay;
            player3Area.GetComponent<Image>().color = cannotPlay;

            for (int i = 0; i < player1Hand.transform.childCount; i++)
            {
                player1Hand.transform.GetChild(i).GetComponent<DragAndDrop>().enabled = true;
            }

            for (int i = 0; i < player2Hand.transform.childCount; i++)
            {
                player2Hand.transform.GetChild(i).GetComponent<DragAndDrop>().enabled = false;
            }

            for (int i = 0; i < player3Hand.transform.childCount; i++)
            {
                player3Hand.transform.GetChild(i).GetComponent<DragAndDrop>().enabled = false;
            }
        }
        else if (turnPlayer.player2HasToPlay)
        {
            player1Area.GetComponent<Image>().color = cannotPlay;
            player2Area.GetComponent<Image>().color = canPlay;
            player3Area.GetComponent<Image>().color = cannotPlay;

            for (int i = 0; i < player2Hand.transform.childCount; i++)
            {
                player2Hand.transform.GetChild(i).GetComponent<DragAndDrop>().enabled = true;
            }
            for (int i = 0; i < player1Hand.transform.childCount; i++)
            {
                player1Hand.transform.GetChild(i).GetComponent<DragAndDrop>().enabled = false;
            }

            for (int i = 0; i < player3Hand.transform.childCount; i++)
            {
                player3Hand.transform.GetChild(i).GetComponent<DragAndDrop>().enabled = false;
            }
        } 
        else if (turnPlayer.player3HasToPlay)
        {
            player1Area.GetComponent<Image>().color = cannotPlay;
            player2Area.GetComponent<Image>().color = cannotPlay;
            player3Area.GetComponent<Image>().color = canPlay;

            for (int i = 0; i < player3Hand.transform.childCount; i++)
            {
                player3Hand.transform.GetChild(i).GetComponent<DragAndDrop>().enabled = true;
            }

            for (int i = 0; i < player1Hand.transform.childCount; i++)
            {
                player1Hand.transform.GetChild(i).GetComponent<DragAndDrop>().enabled = false;
            }

            for (int i = 0; i < player2Hand.transform.childCount; i++)
            {
                player2Hand.transform.GetChild(i).GetComponent<DragAndDrop>().enabled = false;
            }
        }
    }
}


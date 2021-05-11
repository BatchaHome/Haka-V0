using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNobori : MonoBehaviour
{
    public GameObject player1Nobori;
    public GameObject player2Nobori;
    public GameObject player3Nobori;

    public GameObject noboriDoublePoint;
    public GameObject noboriPeoplesPoint;
    public GameObject noboriChangeHands;
    public GameObject noboriSeeCards;
    public GameObject noboriZeroPoints;

    public void CreatingNoboris()
    {
        CreateNoborisForPlayer1();
        CreateNoborisForPlayer2();
        CreateNoborisForPlayer3();
    }

    public void CreateNoborisForPlayer1()
    {
        GameObject noboriDoublePointInstantiated = Instantiate(noboriDoublePoint, new Vector3(0, 0, 0), Quaternion.identity);
        noboriDoublePointInstantiated.transform.SetParent(player1Nobori.transform, false);
        noboriDoublePointInstantiated.tag = "Player1";

        GameObject noboriPeoplesPointInstantiated = Instantiate(noboriPeoplesPoint, new Vector3(0, 0, 0), Quaternion.identity);
        noboriPeoplesPointInstantiated.transform.SetParent(player1Nobori.transform, false);
        noboriPeoplesPointInstantiated.tag = "Player1";

        GameObject noboriChangeHandsInstantiated = Instantiate(noboriChangeHands, new Vector3(0, 0, 0), Quaternion.identity);
        noboriChangeHandsInstantiated.transform.SetParent(player1Nobori.transform, false);
        noboriChangeHandsInstantiated.tag = "Player1";

        GameObject noboriSeeCardsInstantiated = Instantiate(noboriSeeCards, new Vector3(0, 0, 0), Quaternion.identity);
        noboriSeeCardsInstantiated.transform.SetParent(player1Nobori.transform, false);
        noboriSeeCardsInstantiated.tag = "Player1";

        GameObject noboriZeroPointsInstantiated = Instantiate(noboriZeroPoints, new Vector3(0, 0, 0), Quaternion.identity);
        noboriZeroPointsInstantiated.transform.SetParent(player1Nobori.transform, false);
        noboriZeroPointsInstantiated.tag = "Player1";
    }

    public void CreateNoborisForPlayer2()
    {
        GameObject noboriDoublePointInstantiated = Instantiate(noboriDoublePoint, new Vector3(0, 0, 0), Quaternion.identity);
        noboriDoublePointInstantiated.transform.SetParent(player2Nobori.transform, false);
        noboriDoublePointInstantiated.tag = "Player2";

        GameObject noboriPeoplesPointInstantiated = Instantiate(noboriPeoplesPoint, new Vector3(0, 0, 0), Quaternion.identity);
        noboriPeoplesPointInstantiated.transform.SetParent(player2Nobori.transform, false);
        noboriPeoplesPointInstantiated.tag = "Player2";

        GameObject noboriChangeHandsInstantiated = Instantiate(noboriChangeHands, new Vector3(0, 0, 0), Quaternion.identity);
        noboriChangeHandsInstantiated.transform.SetParent(player2Nobori.transform, false);
        noboriChangeHandsInstantiated.tag = "Player2";

        GameObject noboriSeeCardsInstantiated = Instantiate(noboriSeeCards, new Vector3(0, 0, 0), Quaternion.identity);
        noboriSeeCardsInstantiated.transform.SetParent(player2Nobori.transform, false);
        noboriSeeCardsInstantiated.tag = "Player2";

        GameObject noboriZeroPointsInstantiated = Instantiate(noboriZeroPoints, new Vector3(0, 0, 0), Quaternion.identity);
        noboriZeroPointsInstantiated.transform.SetParent(player2Nobori.transform, false);
        noboriZeroPointsInstantiated.tag = "Player2";
    }

    public void CreateNoborisForPlayer3()
    {
        GameObject noboriDoublePointInstantiated = Instantiate(noboriDoublePoint, new Vector3(0, 0, 0), Quaternion.identity);
        noboriDoublePointInstantiated.transform.SetParent(player3Nobori.transform, false);
        noboriDoublePointInstantiated.tag = "Player3";

        GameObject noboriPeoplesPointInstantiated = Instantiate(noboriPeoplesPoint, new Vector3(0, 0, 0), Quaternion.identity);
        noboriPeoplesPointInstantiated.transform.SetParent(player3Nobori.transform, false);
        noboriPeoplesPointInstantiated.tag = "Player3";

        GameObject noboriChangeHandsInstantiated = Instantiate(noboriChangeHands, new Vector3(0, 0, 0), Quaternion.identity);
        noboriChangeHandsInstantiated.transform.SetParent(player3Nobori.transform, false);
        noboriChangeHandsInstantiated.tag = "Player3";

        GameObject noboriSeeCardsInstantiated = Instantiate(noboriSeeCards, new Vector3(0, 0, 0), Quaternion.identity);
        noboriSeeCardsInstantiated.transform.SetParent(player3Nobori.transform, false);
        noboriSeeCardsInstantiated.tag = "Player3";

        GameObject noboriZeroPointsInstantiated = Instantiate(noboriZeroPoints, new Vector3(0, 0, 0), Quaternion.identity);
        noboriZeroPointsInstantiated.transform.SetParent(player3Nobori.transform, false);
        noboriZeroPointsInstantiated.tag = "Player3";
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    public ArePlayersHaveRedCards arePlayersHaveRedCards;
    public IsARedCard isARedCard;
    public CanDropOnTable canDropOnTable;
    public TurnPlayer turnPlayer;

    public GameObject player1Hand;
    public GameObject player2Hand;
    public GameObject player3Hand;
    public GameObject table;
    public GameObject startParent;

    public bool isOverTable;
    public bool isDragging;

    private Vector2 startPosition;

    private void Awake()
    {
        table = GameObject.Find("Table");
        turnPlayer = table.GetComponent<TurnPlayer>();
    }

    public void OnMouseDown()
    {
        startParent = transform.parent.gameObject;
        startPosition = transform.position;

        player1Hand = GameObject.Find("Player1Hand");
        player2Hand = GameObject.Find("Player2Hand");
        player3Hand = GameObject.Find("Player3Hand");

        if (transform.IsChildOf(player1Hand.transform))
        {
            arePlayersHaveRedCards = player1Hand.GetComponent<ArePlayersHaveRedCards>();
            arePlayersHaveRedCards.PlayerHasRedCardsInHand(gameObject);
        }
        else if (transform.IsChildOf(player2Hand.transform))
        {
            arePlayersHaveRedCards = player2Hand.GetComponent<ArePlayersHaveRedCards>();
            arePlayersHaveRedCards.PlayerHasRedCardsInHand(gameObject);
        }
        else if (transform.IsChildOf(player3Hand.transform))
        {
            arePlayersHaveRedCards = player3Hand.GetComponent<ArePlayersHaveRedCards>();
            arePlayersHaveRedCards.PlayerHasRedCardsInHand(gameObject);
        }

        isARedCard = table.GetComponent<IsARedCard>();
        canDropOnTable = table.GetComponent<CanDropOnTable>();

        isARedCard.RedCardOnTable();

        canDropOnTable.CanDropCardOnTable(gameObject, arePlayersHaveRedCards.isPlayerHasRedCards, isARedCard.isARedCardOnTable);
        Debug.Log("Drag begon");
        isDragging = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isOverTable = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isOverTable = false;
    }

    public void OnMouseUp()
    {
        if (isOverTable && canDropOnTable.canDropHisCardOnTable)
        {
            transform.SetParent(table.transform, true);
            turnPlayer.cardsInTable.Add(gameObject);

        }
        else
        {
            transform.position = startPosition;
            transform.SetParent(startParent.transform, false);
        }

        Debug.Log("Drag ended");
        isDragging = false;
    }
    void Update()
    {
        if (isDragging)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePosition, Space.World);
        }
    }
}

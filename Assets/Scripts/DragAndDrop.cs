using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    public ArePlayersHaveRedCards arePlayersHaveRedCards;
    public IsARedCard isARedCard;
    public CanDropOnTable canDropOnTable;
    public TurnPlayer turnPlayer;
    public ListCardsTable listCardsTable;
    public CreatingCards creatingCards;
    public WinningByOldMadManCard winningByOMMC;

    public GameObject mainCanvas;
    public GameObject player1Hand;
    public GameObject player2Hand;
    public GameObject player3Hand;
    public GameObject tableDropZone;
    public GameObject startParent;

    public bool isOverTable;
    public bool isDragging;

    private Vector2 startPosition;

    private void Awake()
    {
        mainCanvas = GameObject.Find("MainCanvas");
        player1Hand = GameObject.Find("Player1Hand");
        player2Hand = GameObject.Find("Player2Hand");
        player3Hand = GameObject.Find("Player3Hand");
        tableDropZone = GameObject.Find("DropZone");
        turnPlayer = mainCanvas.GetComponent<TurnPlayer>();
        creatingCards = mainCanvas.GetComponent<CreatingCards>();
        winningByOMMC = mainCanvas.GetComponent<WinningByOldMadManCard>();
        listCardsTable = tableDropZone.GetComponent<ListCardsTable>();
    }

    public void OnMouseDown()
    {
        startParent = transform.parent.gameObject;
        startPosition = transform.position;

       if (gameObject.transform.IsChildOf(player1Hand.transform))
        {
            arePlayersHaveRedCards = player1Hand.GetComponent<ArePlayersHaveRedCards>();
        }
        else if (gameObject.transform.IsChildOf(player2Hand.transform))
        {
            arePlayersHaveRedCards = player2Hand.GetComponent<ArePlayersHaveRedCards>();
        }
        else if (gameObject.transform.IsChildOf(player3Hand.transform))
        {
            arePlayersHaveRedCards = player3Hand.GetComponent<ArePlayersHaveRedCards>();
        }

        isARedCard = tableDropZone.GetComponent<IsARedCard>();
        canDropOnTable = tableDropZone.GetComponent<CanDropOnTable>();

        isARedCard.RedCardOnTable();

        canDropOnTable.CanDropCardOnTable(gameObject, arePlayersHaveRedCards.isPlayerHasRedCards, isARedCard.isARedCardOnTable);
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
            if (transform.IsChildOf(player1Hand.transform))
            {
                if (creatingCards.cards.IndexOf(gameObject) >= 17)
                {
                    winningByOMMC.isPlayer1PlayedOMM = true;
                }
                else
                {
                    winningByOMMC.isPlayer1PlayedOMM = false;
                }

                turnPlayer.player1HavePlayed = true;
                turnPlayer.SystemTurnPlayer();
            }
            else if (transform.IsChildOf(player2Hand.transform))
            {
                if (creatingCards.cards.IndexOf(gameObject) >= 17)
                {
                    winningByOMMC.isPlayer2PlayedOMM = true;
                }
                else
                {
                    winningByOMMC.isPlayer2PlayedOMM = false;
                }

                turnPlayer.player2HavePlayed = true;
                turnPlayer.SystemTurnPlayer();
            }
            else if (transform.IsChildOf(player3Hand.transform))
            {
                if (creatingCards.cards.IndexOf(gameObject) >= 17)
                {
                    winningByOMMC.isPlayer3PlayedOMM = true;
                }
                else
                {
                    winningByOMMC.isPlayer3PlayedOMM = false;
                }

                turnPlayer.player3HavePlayed = true;
                turnPlayer.SystemTurnPlayer();
            }
                    
            if (!listCardsTable.cardsInTable.Contains(gameObject))
            {
                listCardsTable.cardsInTable.Add(gameObject);
            }

            transform.SetParent(tableDropZone.transform, true);
        }
        else
        {
            transform.position = startPosition;
            transform.SetParent(startParent.transform, false);
        }

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

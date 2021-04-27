using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop : MonoBehaviour
{
    public GameObject canvas;
    public GameObject goze;

    public CanDropOnTable canDropOnTable;
    

    public GameObject table;
    private GameObject startParent;
    public TurnPlayer turnPlayer;
    public IsARedCard isARedCard;
    public ArePlayersHaveRedCards arePlayersHaveRedCards;

    public bool isDragging = false;
    private bool isOverTable = false;
    
    private Vector2 startPosition;

    
    private void Awake()
    {
        canvas = GameObject.Find("MainCanvas");
        table = GameObject.Find("Table");
        canDropOnTable = table.GetComponent<CanDropOnTable>();
        turnPlayer = table.GetComponent<TurnPlayer>();
        isARedCard = table.GetComponent<IsARedCard>();
        
    }

    private void Update()
    {
        if (isDragging)
        {
            transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            //transform.SetParent(canvas.transform, true);  
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isOverTable = true;
        arePlayersHaveRedCards = gameObject.GetComponentInParent<ArePlayersHaveRedCards>();

        arePlayersHaveRedCards.PlayerHasRedCardsInHand(gameObject);
        isARedCard.RedCardOnTable();

        canDropOnTable.CanDropCardOnTable(gameObject, arePlayersHaveRedCards.isPlayerHasRedCards, isARedCard.isARedCardOnTable);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isOverTable = false;
        table = null;
    }

    public void StartDrag()
    {
        table = GameObject.Find("Table");

        if (!transform.IsChildOf(table.transform))
        {
            StartDragging();
        }
    }

    public void EndDrag()
    {
        table = GameObject.Find("Table");

        if (!transform.IsChildOf(table.transform))
        {
            EndDragging();
        }
    }

    
    public void StartDragging()
    {
        startParent = transform.parent.gameObject;
        startPosition = transform.position;
        isDragging = true;
    }

    public void EndDragging()
    {
        isDragging = false;
        if (isOverTable && canDropOnTable.canDropHisCardOnTable)
        {
            transform.SetParent(table.transform, true);
            turnPlayer.cardsInTable.Add(gameObject);

            canDropOnTable.canDropHisCardOnTable = false;
        }
        else
        {
            transform.position = startPosition;
            transform.SetParent(startParent.transform, false);
        }
    }

}

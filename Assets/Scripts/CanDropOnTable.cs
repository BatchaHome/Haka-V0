using UnityEngine;

public class CanDropOnTable : MonoBehaviour
{
    public GameObject tableDropZone;
    public IsARedCard isARedCard;
    public CreatingCards creatingCards;
    public DrawingCards drawingCards;

    public bool canDropHisCardOnTable;

    public void CanDropCardOnTable(GameObject cardInHand, bool playerHaveRedCard, bool redCardOnTable)
    {
        if (!cardInHand.transform.IsChildOf(tableDropZone.transform))
        {
            Debug.Log("On Analyse la carte si elle peut être drop sur la table");

            if (creatingCards.cards.IndexOf(cardInHand) < 8 && redCardOnTable && playerHaveRedCard)
            {
                canDropHisCardOnTable = false;
                Debug.Log("Tu as encore des cartes rouges et une carte rouge à déjà été jouée, tu es obligé de jouer une carte rouge");
            }
            else if (creatingCards.cards.IndexOf(cardInHand) < 8 && redCardOnTable && !playerHaveRedCard)
            {
                canDropHisCardOnTable = true;
                Debug.Log("Une carte rouge a été joué mais tu n'as plus de cartes rouges, donc tu peux jouer une carte bleue");
            }
            else if (creatingCards.cards.IndexOf(cardInHand) > 7 && redCardOnTable)
            {
                canDropHisCardOnTable = true;
            }
            else if (!redCardOnTable)
            {
                canDropHisCardOnTable = true;
            }
        }
    }
}

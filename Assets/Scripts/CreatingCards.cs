using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreatingCards : MonoBehaviour
{

    public GameObject peopleCard;
    public GameObject samouraiCard;
    public GameObject oldMadManCard;
    public GameObject deck;

    private Text peopleCardText;
    private Text samouraiCardText;
    private Text oldMadManCardText;

    public List<GameObject> cards = new List<GameObject>();

     public void CreatePeopleCards()
    {
        for (int i = 11; i <= 18; i++)
        {

            GameObject peopleCardInstantiate = Instantiate(peopleCard, new Vector3(0, 0, 0), Quaternion.identity);
            peopleCardInstantiate.transform.SetParent(deck.transform, false);

            peopleCardText = peopleCardInstantiate.GetComponentInChildren<Text>();
            peopleCardText.text = i.ToString();

            peopleCardInstantiate.transform.position = deck.transform.position;

            cards.Add(peopleCardInstantiate);

        }
    }

    public void CreateSamouraiCards()
    {
        for (int i = 19; i < 28; i++)
        {
            GameObject samouraiCardInstantiated = Instantiate(samouraiCard, new Vector3(0, 0, 0), Quaternion.identity);
            samouraiCardInstantiated.transform.SetParent(deck.transform, false);

            samouraiCardText = samouraiCardInstantiated.GetComponentInChildren<UnityEngine.UI.Text>();
            samouraiCardText.text = i.ToString();

            samouraiCardInstantiated.transform.position = deck.transform.position;

            cards.Add(samouraiCardInstantiated);
        }
    }

    public void CreateOldMadManCards()
    {
        for (int i = 28; i < 31; i++)
        {
            GameObject oldMadManCardInstantiated = Instantiate(oldMadManCard, new Vector3(0, 0, 0), Quaternion.identity);
            oldMadManCardInstantiated.transform.SetParent(deck.transform, false);

            oldMadManCardText = oldMadManCardInstantiated.GetComponentInChildren<UnityEngine.UI.Text>();
            oldMadManCardText.text = "Vieux Fou";

            oldMadManCardInstantiated.transform.position = deck.transform.position;

            cards.Add(oldMadManCardInstantiated);
        }
    }
}
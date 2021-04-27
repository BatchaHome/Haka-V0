using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatingCards : MonoBehaviour
{
    private List<GameObject> createdCards = new List<GameObject>();
    public int maxCards = 30;
    void Awake()
    {
        public GameObject cards = GameObject.FindGameObjectWithTag("Card");
        
    }

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <= maxCards; i++)
        {
            GameObject instantiateCard = Instantiate(cards, transform.position, transform.rotation);
            createdCards.Add(instantiateCard);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

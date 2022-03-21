using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collection : MonoBehaviour
{
    [SerializeField]
    public CardManager cardManager;
    public GameObject[] cardSlots;



    void Start()
    {
        DisplayCard();
    }

    void Update()
    {

    }

    private void DisplayCard()
    {
        for (int i = 0; i < cardManager.cards.Count; i++)
        {
            // cardSlots[i].transform.GetChild(6).transform.GetChild(0).GetComponent<Text>().text = cardManager.cards[i];
        }
    }
}

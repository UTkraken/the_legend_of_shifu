using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Collection : MonoBehaviour
{
    [SerializeField]
    //public CardManager cardManager;
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
        /*for (int i = 0; i < cardManager.cards.Count; i++)
        {
            cardSlots[i].transform.GetChild(2).transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = ""+cardManager.cards[i].textSymbol;
        }*/
    }
}

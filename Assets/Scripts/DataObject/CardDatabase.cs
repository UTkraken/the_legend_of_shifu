using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using DataObject;

[System.Serializable]
public class CardDatabase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>();

    void Awake()
    {
        cardList.Add(new Card(1, "symbole", "text symbole"));
        cardList.Add(new Card(2, "symbole22", "text symbole222"));
        cardList.Add(new Card(3, "symbole22", "text symbole222"));
        cardList.Add(new Card(4, "symbole22", "text symbole222"));
    }
}

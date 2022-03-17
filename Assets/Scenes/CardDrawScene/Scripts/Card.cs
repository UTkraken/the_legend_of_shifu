using System.Collections;
using UnityEngine;

public class Card : MonoBehaviour
{

    public int CardId;
    public string CardName;

    public Card(int cardId,string cardName)
    {
        CardId = cardId;
        CardName = cardName;
    }
}
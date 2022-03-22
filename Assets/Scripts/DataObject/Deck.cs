using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DataObject;



namespace DataObject
{
    [System.Serializable]
    public class Deck : MonoBehaviour
    {
        public List<Card> cards = new List<Card>();
        
        void Start()
        {
            cards[0] = CardDatabase.cardList[0];
            cards[1] = CardDatabase.cardList[1];
            cards[2] = CardDatabase.cardList[2];
        }
       
    }
}

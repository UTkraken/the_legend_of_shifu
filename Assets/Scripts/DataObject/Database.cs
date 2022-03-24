using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using DataObject;

namespace DataObject
{
    [System.Serializable]
    public class Database : MonoBehaviour
    {
        private static List<Card> cardList = new List<Card>();
        
        public static List<Card> deck = new List<Card>();

        private void Start()
        {
            initCardList();
            createDeck();
        }

        void initCardList()
        {
            cardList.Add(new Card(1, "Pierre", "text symbole", 1));
            cardList.Add(new Card(2, "Feuille", "text symbole222", 1));
            cardList.Add(new Card(3, "Ciseaux", "text symbole222", 1));
        }

        void createDeck()
        {
            deck.Add(new Card(1, "Pierre", "Pierre", 1));
            deck.Add(new Card(2, "Feuille", "Feuille", 1));
            deck.Add(new Card(3, "Ciseaux", "Ciseaux", 1));

        }
    }
}

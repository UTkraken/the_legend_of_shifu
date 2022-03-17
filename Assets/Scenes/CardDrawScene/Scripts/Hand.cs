using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Scenes.CardDrawScene.Scripts
{
    public class Hand: MonoBehaviour
    {
        private List<Card> hand = new List<Card>();
        public int handSize = 3;

        /*void Start()
        {
            for(int i = 0; i < handSize; i++)
            {
                var cardDrawn = Stock.cardList.ElementAt(i);
                hand.Add(new Card(cardDrawn.CardId, cardDrawn.CardName));
                hand[i] = Stock.cardList[i];
                Debug.Log(hand[i]);
            }
        }*/
        


    }
}
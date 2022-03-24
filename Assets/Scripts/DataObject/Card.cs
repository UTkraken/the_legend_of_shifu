using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

namespace DataObject
{
    [System.Serializable]
    public class Card
    {
        public int id;
        public string symbol;
        public string textSymbol;
       // public TextMeshProUGUI textSymbol;

        public int amount = 0;

        //private Sprite ThisImage;

        public Card() { }

        public Card(
            int id,
            string symbol,
            string textSymbol,
            int amount)
        {
            this.id = id;
            this.symbol = symbol;
            this.textSymbol = textSymbol;
            //this.ThisImage = ThisImage;
            this.amount = amount;
        }

    }
}
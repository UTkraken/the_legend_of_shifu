using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]

namespace DataObject
{
    public class Card
    {
        private int id;
        private string symbol;
        private string textSymbol;

        private Sprite ThisImage;

        public Card() { }

        public Card(int id, string symbol, string textSymbol, Sprit ThisImage)
        {
            this.id = id;
            this.symbol = symbol;
            this.textSymbol = textSymbol;
            this.ThisImage = ThisImage;
        }

    }
}
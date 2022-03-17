using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DataObject
{
    [System.Serializable]
    public class Card : MonoBehaviour
    {
        private int id;
        private string symbol;
        private string textSymbol;

        private Sprite ThisImage;

        public Card() { }

        public Card(int id, string symbol, string textSymbol, Sprite ThisImage)
        {
            this.id = id;
            this.symbol = symbol;
            this.textSymbol = textSymbol;
            this.ThisImage = ThisImage;
        }

    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

namespace DataObject
{
    [System.Serializable]
    public class Card : MonoBehaviour
    {
        public int id;
        public string textSymbol;
        public Sprite ThisSprite;


        public Card() { }

        public Card(
            int id,
            string textSymbol,
            Sprite thisSprite)
        {
            this.id = id;
            this.textSymbol = textSymbol;
            this.ThisSprite = thisSprite;
        }

    }
}
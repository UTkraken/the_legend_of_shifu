using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DataObject
{
    public class Player : Creature
    {

        private int goldCount;

        List<Cards> available_cards = new List<Cards>();

        Deck deck = new Deck();

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DataObject;
using TMPro;

public class ThisCard : MonoBehaviour
{
    private GameObject hand;
    public GameObject It;
    private List<Card> deck = new List<Card>();
    public List<Card> this_card = new List<Card>();
    
    public int id;
    public string symbol;
    public string text_symbol;

    public TextMeshProUGUI this_text_symbol;
    // Start is called before the first frame update
    
    void Start()
    { 
        this_card.Add(Database.deck[FightManager.deckIndex]);
        hand = GameObject.Find("Hand");
        
        id = this_card[0].id;
        this_text_symbol.text = this_card[0].textSymbol;

        this.transform.parent = hand.transform;
        It.transform.SetParent(hand.transform);
        It.transform.localScale = Vector3.one;
        It.transform.position = new Vector3(transform.position.x + (FightManager.deckIndex), transform.position.y, -1);
        It.transform.eulerAngles = new Vector3(25 ,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        /*
        hand = GameObject.Find("Hand");
        
        id = this_card[0].id;
        this_text_symbol.text = this_card[0].textSymbol;

        this.transform.parent = hand.transform;
        It.transform.SetParent(hand.transform);
        It.transform.localScale = Vector3.one;
        It.transform.position = new Vector3(transform.position.x+ (FightManager.deckIndex * 150), transform.position.y, -1);
        It.transform.eulerAngles = new Vector3(25 ,0,0);
        */

    }
}

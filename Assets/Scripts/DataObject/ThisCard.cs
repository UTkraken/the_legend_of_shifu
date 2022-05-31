using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DataObject;
using TMPro;
using UnityEngine.UI;

public class ThisCard : MonoBehaviour
{
    private GameObject hand;
    public GameObject It;
    private List<Card> deck = new List<Card>();
    public List<Card> this_card = new List<Card>();
    
    public int id;
    public string text_symbol;
    public Sprite this_sprite;
    public Image that_image;

    public TextMeshProUGUI this_text_symbol;


    void Start()
    { 
        this_card.Add(Database.deck[FightManager.deckIndex]);
        hand = GameObject.Find("Hand");
        
        id = this_card[0].id;
        this_text_symbol.text = this_card[0].textSymbol;

        if (id ==  0) {
            that_image.sprite = Resources.Load<Sprite>("stone");
        }
        if (id ==  1) {
            that_image.sprite = Resources.Load<Sprite>("leaf");
        }
        if (id ==  2) {
            that_image.sprite = Resources.Load<Sprite>("sci");
        }
    }
}

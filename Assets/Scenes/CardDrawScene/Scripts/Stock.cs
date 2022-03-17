using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Stock : MonoBehaviour
{

    public static List<Card> originalCardList = new List<Card>();
    public static List<Card> discardList = new List<Card>();
    public static List<Card> cardInStockList = new List<Card>();

    private List<Card> cardsInHandList = new List<Card>();
    
    private int currentCardIndex;

    // Start is called before the first frame update
    void Start()
    {
        originalCardList.Add(new Card(1, "lucas"));
        originalCardList.Add(new Card(2, "arthur"));
        originalCardList.Add(new Card(3, "yvan"));
        originalCardList.Add(new Card(4, "clément"));
        originalCardList.Add(new Card(5, "thomas"));
        originalCardList.Add(new Card(6, "ryan"));
        
        //discardList.Add(new Card(45, "Cthulu"));
        //discardList.Add(new Card(89, "Jésus"));

        currentCardIndex = originalCardList.Count-1;
        Debug.Log(currentCardIndex);
        cardInStockList = new List<Card>(originalCardList);
        
        Draw();
        Draw();
        Draw();
        foreach(var card in cardsInHandList)
        {
            Debug.Log("Carte en main : " + card.CardId);
        }
        
        Discard(6);
        foreach(var card in cardsInHandList)
        {
            Debug.Log("Carte en main après discard: " + card.CardId);
        }
    }

    void Draw()
    {
        if (currentCardIndex < 0)
        {
            ShuffleGraveyardInStock();
            //Debug.Log("Nombre de cartes"  +   currentCardIndex);
        }
        Card cardDrawn = cardInStockList.ElementAt(currentCardIndex);
        cardsInHandList.Add(new Card(cardDrawn.CardId, cardDrawn.CardName));
        currentCardIndex--;
        Debug.Log("Carte piochée " + cardDrawn.CardId);
    }

    /*Remove a card from player's hand and put it in the discard pile
     * 
     * param int cardId
     */
    void Discard(int cardId)
    {
        Debug.Log("Carte à défausser, ID : " + cardId);
        foreach(var card in cardsInHandList)
        {
            if (card.CardId == cardId)
            {
                Card cardToFuckingDelete = new Card(card.CardId, card.CardName);
                discardList.Add(cardToFuckingDelete);
                cardsInHandList.RemoveAll(c => c.CardId == cardId);
                Debug.Log("Carte supprimée");
            }
        }
              
               
                
        //discardList.Add(new Card(card.CardId, card.CardName));
        //cardsInHandList.RemoveAll(c => c.CardId == cardId);

    }
    
    /*Takes a list of Card elements then return a shuffle version of it
     * 
     * param List<Card>
     * return List<Card>
     */
    private List<Card> Shuffle(List<Card> cardList)
    {
        return cardList.OrderBy(a => Guid.NewGuid()).ToList();
    }

    private void ShuffleGraveyardInStock()
    {
        cardInStockList = Shuffle(discardList);
        discardList.Clear();
        currentCardIndex = cardInStockList.Count-1;
    }
    
    // Update is called once per frame
    void Update()
    {

        
        //Draw();

    }
}

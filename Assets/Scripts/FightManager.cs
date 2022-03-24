using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

using DataObject;

public class FightManager : MonoBehaviour
{
    private Player player;
    private PNJ pNJ;
    private Card selectedCard;
    private int round = 0;
    public static int deckIndex = 0;

    private List<Card> actualDeck = new List<Card>();
    public GameObject Card;
    
    // Start is called before the first frame update
    void Start()
    {
        // await DisplayNarration();
        FightInitialisation();
    }

    // Update is called once per frame
    void Update()
    {

    }

    /**
     * <summary>Condition de fin de combat.</summary>
     * <returns>Retourne Vrai si le combat est terminé, et Faux sinon.</returns> 
     **/
    private bool IsFightEnded()
    {
        return pNJ.GetHealth() == 0 || player.GetHealth() == 0;
    }

    /**
     * <summary>Gère les actions de fin de combat dans le cas d'une fin de combat</summary>
     **/
    private void ManageEndFight()
    {
        // Cas de Victoire
        if (this.pNJ.GetHealth() == 0)
        {
            // await WinAnimation();
            // do reward etc
            // return to Map
        // Case de défaite
        } else
        {
            // await GameOverAnimation();
            // reset de la save
            // return to main menu
        }
        this.enabled = false;
    }

    /**
     * <summary>Etape d'initialisation du combat</summary>
     **/
    private void FightInitialisation()
    {
        // HandleFirstDraw(player.GetDeck());
        StartCoroutine(InitDeckInHand());
        //player.FullHeal();
        this.round++;
    }

    IEnumerator InitDeckInHand()
    {
        actualDeck = Database.deck;
        Shuffle();
        for (int i = 0; i < 3; i++)
        {
            yield return new WaitForSeconds(0.01f);     
            StartCoroutine(Draw());
           
        }
    }

    IEnumerator Draw()
    {
        Instantiate(Card, transform.position, transform.rotation);
        yield return new WaitForSeconds(0.1f);
        deckIndex++;

    }
    void Shuffle()
    {
        actualDeck = actualDeck.OrderBy(a => Guid.NewGuid()).ToList();          
    }
    /**
     * <summary>Etape de comparaison des symboles entre joueur et bot.</summary>
     **/
    private void CardComparison()
    {
        // DestroyCard(selectedCard);
        Card botCard = new Card(1, "coucou", "coucou", 1);//BotCardChoice();

        // await ComparisonCardAnimiation();

        switch (Comparer(this.selectedCard, botCard))
        {
            case ResultComparison.Defeat:
                // await DestroyAnimation(this.selectedCard);
                // await DefeatAnimation();
                player.LoseHealth(1);
                break;
            case ResultComparison.Equality:
                // await EqualityAnimation();
                break;
            case ResultComparison.Victory:
                // await DestroyAnimation(botCard);
                // await VictoyAnimation();
                pNJ.LoseHealth(1);
                break;

        }

        if (this.IsFightEnded()) {
            ManageEndFight();
        } else
        {
            InitialisationRound();            
        }
    }

    /**
     * <summary>Compare la carte du joueur avec la carte du bot.</summary>
     * <param name="firstCard">La main carte de la comparaison.</param>
     * <param name="secondCard">La main carte de la comparaison.</param>
     * <returns>Retourne un ResultComparison qui vaux victoire, égalité ou défaite.</returns>
     **/
    private ResultComparison Comparer(Card firstCard, Card secondCard)
    {
        // TODO
        /*if (firstCard.winAgainst(selectedCard))
        {
            return ResultComparison.Victory;
        } else if (firstCard.isEqual(secondCard))
        {
            return ResultComparison.Equality;
        } else
        {
            return ResultComparison.Defeat;
        }*/

        return ResultComparison.Victory;
    }

    /**
     * <summary>Etape de sélection de la carte.</summary>
     * <param name="card">La carte choisi par le joueur.</param>
     **/
    public void SetCardSelected(Card card)
    {
        this.selectedCard = card;
        CardComparison();
    }

    /**
     * <summary>Etape d'initialisation d'un nouveau round.</summary>
     **/
    public void InitialisationRound()
    {
        // HandleDraw();
        // await DrawAnimation();
        this.round++;
    }
}

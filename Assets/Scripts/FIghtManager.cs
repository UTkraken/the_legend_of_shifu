using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using DataObject;

public class FightManager : MonoBehaviour
{
    private Player player;
    private PNJ pNJ;
    private Card selectedCard;
    private int round = 0;

    // TODO placer dans un fichier
    enum ResultComparison
    {
        Defeat,
        Equality,
        Victory
    }

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

    private bool IsFightEnded()
    {
        return pNJ.GetHealth() == 0 || player.GetHealth() == 0;
    }

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

    private void FightInitialisation()
    {
        // HandleFirstDraw(player.GetDeck());
        player.FullHeal();
        this.round++;
    }

    private void CardComparison()
    {
        // DestroyCard(selectedCard);
        Card botCard = new Card();//BotCardChoice();

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

    public void SetCardSelected(Card card)
    {
        CardComparison();
    }

    public void InitialisationRound()
    {
        // HandleDraw();
        // await DrawAnimation();
        this.round++;
    }
}

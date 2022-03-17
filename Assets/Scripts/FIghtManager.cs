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
    private bool taskInProgress = true;
    // TODO placer dans un fichier
    enum Step
    {
        InitialisationFight,
        PlayerStep,
        CardComparison,
        InitialisationRound
    }
    // TODO placer dans un fichier
    enum ResultComparison
    {
        Defeat,
        Equality,
        Victory
    }
    private Step step;

    // Start is called before the first frame update
    void Start()
    {
        //DisplayInterface();
        //DisplayNarration();
        step = Step.InitialisationFight;
    }

    // Update is called once per frame
    void Update()
    {
        if (!this.taskInProgress)
        {
            if (this.IsFightInProgress())
            {
                switch(this.step)
                {
                    case Step.InitialisationFight:
                        FightInitialisation();
                        break;
                    case Step.PlayerStep:
                        PlayerStep();
                        break;
                    case Step.CardComparison:
                        CardComparison();
                        break;
                    case Step.InitialisationRound:
                        InitialisationRound();
                        break;
                }
            }
            else
            {
                ManageEndFight();
            }
        }
    }

    private bool IsFightInProgress()
    {
        // TODO check Pv
        return pNJ.GetHealth() > 0 && player.GetHealth() > 0;
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
            // return to main menu
        }
        this.enabled = false;
    }

    private void FightInitialisation()
    {
        this.taskInProgress = true;
        // HandleFirstDraw(player.GetDeck());
        this.round++;
        step = Step.PlayerStep;
        this.taskInProgress = false;        
    }

    private void PlayerStep()
    {
        this.taskInProgress = true;
        //Enable card selection
        step = Step.PlayerStep;
        this.taskInProgress = false;        
    }

    private void CardComparison()
    {
        // Disable selection card
        this.taskInProgress = true;
        // DiscardCard(selectedCard);
        // await ComparisonCardAnimiation();
        Card botCard = new Card();//BotCardChoice();
        switch(Comparer(this.selectedCard, botCard))
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
        // await ComparisonCardAnimiation();
        this.taskInProgress = false;
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
        this.selectedCard = card;
        this.step = Step.CardComparison;
    }

    public void InitialisationRound()
    {
        this.taskInProgress = true;
        // HandleDraw();
        // await DrawAnimation();
        this.round++;
        this.step = Step.PlayerStep;
        this.taskInProgress = false;
    }
}

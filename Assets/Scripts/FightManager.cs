using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random=UnityEngine.Random;
using TMPro;
using UnityEngine.SceneManagement;

public class FightManager : MonoBehaviour
{

    private int round = 0;
    public static int deckIndex = 0;
    public GameObject Card;
    bool death_enemy = false;
    bool death_player = false;
    string enemy_card_play;

    // Start is called before the first frame update
    void Start()
    {
        // await DisplayNarration();
        GameObject.Find("HealthBar").GetComponent<HealthBar>().SetMaxHealth(3);
        GameObject.Find("EnemyHealthBar").GetComponent<HealthBar>().SetMaxHealth(3);
        StartCoroutine(InitDeckInHand());
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator InitDeckInHand()
    {
        deckIndex = 0;
        for (int i = 0; i < 3; i++)
        {
            yield return new WaitForSeconds(0.5f);
            StartCoroutine(Draw());
           
        }
    }

    IEnumerator Draw()
    {
        Instantiate(Card, transform.position, transform.rotation);
        yield return new WaitForSeconds(0.1f);
        deckIndex++;

    }

    /**
     * <summary>Compare la carte du joueur avec la carte du bot.</summary>
     * <param name="firstCard">La main carte de la comparaison.</param>
     * <param name="secondCard">La main carte de la comparaison.</param>
     * <returns>Retourne un ResultComparison qui vaux victoire, égalité ou défaite.</returns>
     **/
    public String Comparer(int id)
    {
        int enemy_card = Random.Range(0, 2);
        int player_card = id;

        // 0 win 2
        // 1 win 0
        // 2 win 1
            if (enemy_card == 0) {
                enemy_card_play = "Pierre";
            }
            if (enemy_card == 1) {
                enemy_card_play = "Feuille";
            }
            if (enemy_card == 2) {
                enemy_card_play = "Ciseaux";
            }
        if (enemy_card == 0 && player_card ==2 || enemy_card == 1 && player_card == 0 || enemy_card == 2 && player_card == 1) {
            GameObject.Find("HealthBar").GetComponent<HealthBar>().looseHealth(1);
            GameObject.Find("Log").GetComponent<ChangeText>().EnemyWin(enemy_card_play);

        }
        else if (enemy_card == 2 && player_card == 0 || enemy_card == 0 && player_card == 1 || enemy_card == 1 && player_card == 2) {
            GameObject.Find("EnemyHealthBar").GetComponent<HealthBar>().looseHealth(1);
            GameObject.Find("Log").GetComponent<ChangeText>().PlayerWin(enemy_card_play);
        }
        else {
            GameObject.Find("Log").GetComponent<ChangeText>().Equality();
        }

        death_player = GameObject.Find("HealthBar").GetComponent<HealthBar>().CheckHealth();
        death_enemy = GameObject.Find("EnemyHealthBar").GetComponent<HealthBar>().CheckHealth();
        if (death_player || death_enemy)
        {
            finCombat();
        }

        return "youpi";
    }

    public void finCombat()
    {
        death_player = GameObject.Find("HealthBar").GetComponent<HealthBar>().CheckHealth();
        death_enemy = GameObject.Find("EnemyHealthBar").GetComponent<HealthBar>().CheckHealth();

        if (death_player)
        {
            //Loose
            UnityEngine.SceneManagement.SceneManager.LoadScene("Landing_Scene");
            Debug.Log("GameOver");
        }
        if (death_enemy)
        {
            //WIN
            //UnityEngine.SceneManagement.SceneManager.LoadScene("game_scene");
            //Debug.Log(UnityEngine.SceneManagement.SceneManager.sceneCount);

            GameObject[] go2 = UnityEngine.SceneManagement.SceneManager.GetSceneByName("game_scene").GetRootGameObjects();
            foreach (GameObject objet2 in go2)
            {
                if (objet2.name != "ennemy1")
                {
                    objet2.SetActive(true);
                }

                if (objet2.name == "player")
                {
                    //unfreeze
                    objet2.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
                }

            }




            GameObject[] go = UnityEngine.SceneManagement.SceneManager.GetSceneByName("CardDrawTest").GetRootGameObjects();
            foreach (GameObject objet in go)
            {

                objet.SetActive(false);
                //Destroy(objet);
            }

            UnityEngine.SceneManagement.SceneManager.UnloadScene("CardDrawTest");

            UnityEngine.SceneManagement.SceneManager.SetActiveScene(UnityEngine.SceneManagement.SceneManager.GetSceneByName("game_scene"));


            Debug.Log("C'est gagné");
        }
    }
}

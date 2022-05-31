using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{

    public Text changingText;

    public void EnemyWin(string txt) {
        changingText.text = "Ton adversaire a gagne en jouant: " +txt;
    }
    public void PlayerWin(string txt) {
        changingText.text = "Ton adversaire a perdu en jouant: " +txt;
    }
    public void Equality() {
        changingText.text = "Vous avez joue la meme carte !";
    }

}

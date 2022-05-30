using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainMenu: MonoBehaviour {

    public Button play;
    public Button library;
    public Button option;
    public Button credit;
    public Button leave;

    void Start()
    {
        play.onClick.AddListener(PlayGameButton);
        library.onClick.AddListener(LibraryButton);
        option.onClick.AddListener(OptionButton);
        credit.onClick.AddListener(CreditsButton);
        leave.onClick.AddListener(LeaveGameButton);

    }

    //TODO set the Library scene once it's ready
    public void LibraryButton()
    {
        Debug.Log("Library");
    }
    
    //TODO set the Option scene once it's ready
    public void OptionButton()
    {
        Debug.Log("Options");
    }
    
    //TODO set the Credits scene once it's ready
    public void CreditsButton()
    {
        Debug.Log("Crédits");
    }

    public void LeaveGameButton()
    {
        Application.Quit();
    }
    
    //TODO set the Play scene once it's ready
    public void PlayGameButton()
    {
        //UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
        Debug.Log("Playing");
    }
}
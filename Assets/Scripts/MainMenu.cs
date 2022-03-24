using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
using UnityEngine.SceneManagement;  
public class MainMenu: MonoBehaviour {  
    
    //TODO set the Library scene once it's ready
    public void LibraryButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
    }
    
    //TODO set the Option scene once it's ready
    public void OptionButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
    }
    
    //TODO set the Credits scene once it's ready
    public void CreditsButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
    }
    public void LeaveGameButton()
    {
        Application.Quit();
    }
    
    //TODO set the Play scene once it's ready
    public void PlayGameButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuButton : MonoBehaviour
{
    //link to the github
    public string URL = "https://github.com/Alex7781/BattleofthePlanes2.0";
    public void LoadScene()
    {
        //Loads scene 1
        SceneManager.LoadScene("Scene 1");
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }


    public void loadUrl()
    {
        //Link of application to the URL
        Application.OpenURL(URL);
        
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene(1);
    }

    public void returnMainMenu()
    {
        
            SceneManager.LoadScene(0);
        
        
    }

    public void exitGame()
    {
        Application.Quit();
    }
}

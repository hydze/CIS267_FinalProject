using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuButtons : MonoBehaviour
{
    public void startGame()
    {
        SceneManager.LoadScene("DemoScene");
    }

    public void settings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void mainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }


    public void exitGame()
    {
        Application.Quit();
    }
}

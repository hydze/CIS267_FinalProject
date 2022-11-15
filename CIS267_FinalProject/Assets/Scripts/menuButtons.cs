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

    public void cheats()
    {
        SceneManager.LoadScene("Cheats");
    }

    public void settings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void mainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ranking()
    {
        SceneManager.LoadScene("Ranking");
    }

    public void sound()
    {
        SceneManager.LoadScene("Sound");
    }

    public void controls()
    {
        SceneManager.LoadScene("Controls");
    }

    public void levelSelect()
    {
        SceneManager.LoadScene("LevelSelect");
    }


    public void exitGame()
    {
        Application.Quit();
    }
}

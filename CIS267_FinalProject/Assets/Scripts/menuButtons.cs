using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuButtons : MonoBehaviour
{
    private void Start()
    {
        Time.timeScale = 1f;
    }

    public void startGame()
    {
        SceneManager.LoadScene("Level1");
    }

    public void cheats()
    {
        SceneManager.LoadScene("LevelSelect");
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

    public void selectLevel1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void selectLevel2()
    {
        SceneManager.LoadScene("Level2");
    }

    public void selectLevel3()
    {
        SceneManager.LoadScene("Level3");
    }



    public void exitGame()
    {
        Application.Quit();
    }


}

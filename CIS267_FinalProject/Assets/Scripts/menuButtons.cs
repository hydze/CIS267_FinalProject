using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class menuButtons : MonoBehaviour
{
    public Button playBtn;
    public Button cheatsBtn;
    public Button rankingsBtn;
    public Button settingsBtn;
    public Button quitBtn;
    public Button world1Btn;
    public Button world2Btn;
    public Button world3Btn;
    public Button cheatsBackBtn;
    public Button resetBtn;
    public Button rankingsBackBtn;
    public Button settingsSoundBtn;
    public Button settingsControlsBtn;
    public Button settingsBackBtn;
    public Button soundBackBtn;
    public Button controlsBackBtn;
    public Button gmMainMenuBtn;
    public Button gmRankingsBtn;
    public Button gmQuitBtn;
    private void Start()
    {
        Scene scene = SceneManager.GetActiveScene();

        if(scene.name == "MainMenu" || scene.name == "GameOver" || scene.name == "Ranking" )
        {
            Time.timeScale = 1f;
        }

        //playBtn.Select();

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

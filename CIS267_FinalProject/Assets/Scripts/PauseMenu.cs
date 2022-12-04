using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool isGamePaused = false;
    public GameObject pauseCavas;


    private void Start()
    {
        resume();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isGamePaused)
            {
                resume();
            } else
            {
                pause();
            }
        }

        if(!isGamePaused)
        {
            Time.timeScale = 1f;
        }
    }

    public void resume()
    {
        FindObjectOfType<fireWeapon>().canFire = true;
        pauseCavas.SetActive(false);
        Time.timeScale = 1f;
        isGamePaused = false;
    }

    public void pause()
    {
        FindObjectOfType<fireWeapon>().canFire = false;
        pauseCavas.SetActive(true);
        Time.timeScale = 0f;
        isGamePaused = true;
    }

    public void loadMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void quitGame()
    {
        Application.Quit();
    }

}

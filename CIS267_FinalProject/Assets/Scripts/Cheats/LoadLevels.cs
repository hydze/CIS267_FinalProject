using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevels : MonoBehaviour
{
    public void levelOne()
    {
        SceneManager.LoadScene("Level1");
    }

    public void levelTwo()
    {
        SceneManager.LoadScene("Level2");
    }

    public void levelThree()
    {
        SceneManager.LoadScene("Level3");
    }
}

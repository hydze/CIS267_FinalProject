using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class L3Powerups : MonoBehaviour
{
    string sceneName = "Level3";
    bool isLevel3 = false;

    private void Update()
    {
        if (SceneManager.GetActiveScene().name == sceneName && !isLevel3)
        {
            isLevel3 = true;
        }
    }
}

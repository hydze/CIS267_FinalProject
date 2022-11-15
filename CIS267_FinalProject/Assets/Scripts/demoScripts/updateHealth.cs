using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class updateHealth : MonoBehaviour
{
    private TextMeshProUGUI hpText;

    // Start is called before the first frame update
    void Start()
    {
        hpText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        hpText.SetText(GameManager.instance.getHealth().ToString() + " : HP");

        if(GameManager.instance.getHealth() <= 0)
        {
            GameManager.instance.removeLives(1);
            //SHIP EXPLODE+RESPAWN HERE
            GameManager.instance.setHealth(100);

        }
    }
}

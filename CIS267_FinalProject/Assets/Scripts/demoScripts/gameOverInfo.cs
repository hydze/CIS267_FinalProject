using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class gameOverInfo : MonoBehaviour
{
    private TextMeshProUGUI Score;
    public TextMeshProUGUI Win;

    // Start is called before the first frame update
    void Start()
    {
        Score = GetComponent<TextMeshProUGUI>();

        if(GameManager.instance.getWin() == true)
        {
            Win.SetText("You Win!");
        }

        Score.SetText("Score : " + GameManager.instance.getScore().ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

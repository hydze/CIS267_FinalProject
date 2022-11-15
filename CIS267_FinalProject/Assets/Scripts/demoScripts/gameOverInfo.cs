using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
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

        saveHighScores();

        ///GAME OVER!!! RESET STATIC VARS HERE INCASE PLAYER PLAYS AGAIN OR WHATEVER
        GameManager.instance.resetPlayerVars();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void saveHighScores()
    {
        if (GameManager.instance.getScore() > PlayerPrefs.GetInt("highScore9", 1)) //we are on board, need to sort it into list
        {

            Win.SetText("New High Score!"); 

            int zero = PlayerPrefs.GetInt("highScore0", 10);  //we could remove these and do it all on array creation if we wanted
            int one = PlayerPrefs.GetInt("highScore1", 9);
            int two = PlayerPrefs.GetInt("highScore2", 8);
            int three = PlayerPrefs.GetInt("highScore3", 7);
            int four = PlayerPrefs.GetInt("highScore4", 6);
            int five = PlayerPrefs.GetInt("highScore5", 5);
            int six = PlayerPrefs.GetInt("highScore6", 4);
            int seven = PlayerPrefs.GetInt("highScore7", 3);
            int eight = PlayerPrefs.GetInt("highScore8", 2);
            int nine = GameManager.instance.getScore(); //our score should be bigger than this if we are on the score board so just drop the smallest high score since it wont be on the list

            int[] scoreArray = new int[10] { zero, one, two, three, four, five, six, seven, eight, nine };

            System.Array.Sort(scoreArray); //sort our list for us
            System.Array.Reverse(scoreArray); //we want DESCENDING for high score

            PlayerPrefs.SetInt("highScore0", scoreArray[0]);
            PlayerPrefs.SetInt("highScore1", scoreArray[1]);
            PlayerPrefs.SetInt("highScore2", scoreArray[2]);
            PlayerPrefs.SetInt("highScore3", scoreArray[3]);
            PlayerPrefs.SetInt("highScore4", scoreArray[4]);
            PlayerPrefs.SetInt("highScore5", scoreArray[5]);
            PlayerPrefs.SetInt("highScore6", scoreArray[6]);
            PlayerPrefs.SetInt("highScore7", scoreArray[7]);
            PlayerPrefs.SetInt("highScore8", scoreArray[8]);
            PlayerPrefs.SetInt("highScore9", scoreArray[9]);

        }
    }
}

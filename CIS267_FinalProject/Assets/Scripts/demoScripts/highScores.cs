using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class highScores : MonoBehaviour
{

    public TextMeshProUGUI highS0; //high
    public TextMeshProUGUI highS1;
    public TextMeshProUGUI highS2;
    public TextMeshProUGUI highS3;
    public TextMeshProUGUI highS4;
    public TextMeshProUGUI highS5;
    public TextMeshProUGUI highS6;
    public TextMeshProUGUI highS7;
    public TextMeshProUGUI highS8;
    public TextMeshProUGUI highS9;

    // Start is called before the first frame update
    void Start()
    {
        displayHighScores();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void displayHighScores()
    {

            highS0.text = "1st " + PlayerPrefs.GetInt("highScore0", 10).ToString();
            highS1.text = "2nd " + PlayerPrefs.GetInt("highScore1", 9).ToString();
            highS2.text = "3rd " + PlayerPrefs.GetInt("highScore2", 8).ToString();
            highS3.text = "4th " + PlayerPrefs.GetInt("highScore3", 7).ToString();
            highS4.text = "5th " + PlayerPrefs.GetInt("highScore4", 6).ToString();
            highS5.text = "6th " + PlayerPrefs.GetInt("highScore5", 5).ToString();
            highS6.text = "7th " + PlayerPrefs.GetInt("highScore6", 4).ToString();
            highS7.text = "8th " + PlayerPrefs.GetInt("highScore7", 3).ToString();
            highS8.text = "9th " + PlayerPrefs.GetInt("highScore8", 2).ToString();
            highS9.text = "10th " + PlayerPrefs.GetInt("highScore9", 1).ToString();

    }



    public void nukeScores() //reset prefs/scores
    {
        PlayerPrefs.SetInt("highScore0", 10);
        PlayerPrefs.SetInt("highScore1", 9);
        PlayerPrefs.SetInt("highScore2", 8);
        PlayerPrefs.SetInt("highScore3", 7);
        PlayerPrefs.SetInt("highScore4", 6);
        PlayerPrefs.SetInt("highScore5", 5);
        PlayerPrefs.SetInt("highScore6", 4);
        PlayerPrefs.SetInt("highScore7", 3);
        PlayerPrefs.SetInt("highScore8", 2);
        PlayerPrefs.SetInt("highScore9", 1);

        //redraw score screen so its not as CLUNKY
        displayHighScores();

    }

}

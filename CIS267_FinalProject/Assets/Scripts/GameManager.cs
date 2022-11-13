using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int score;
    public int lives;
    public int shipHealth;
    public bool gameOver;
    public bool isWin;

    private int enemyCount;

    //any persistent data between scenes can be saved here
    //ship health, lives, score, game over and booleans
    //settings??

    private void Awake()
    {
        load();
    }

    private void load()
    {
        if(instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setScore(int s)
    {
        score += s;
    }

    public int getScore()
    {
        return score;
    }

    public int getHealth()
    {
        return shipHealth;
    }

    public void removeHealth(int d)
    {
        shipHealth -= d;
    }

    public void giveHealth(int h)
    {
        shipHealth += h;
    }

    public void setHealth(int h)
    {
        shipHealth = h;
    }

    public int getLives()
    {
        return lives;
    }

    public void removeLives(int r)
    {
        lives -= r;
    }

    public void giveLives(int l)
    {
        lives += l;
    }

    public void setLives(int l)
    {
        lives = l;
    }

    public void setGameOver()
    {
        gameOver = true;
    }

    public bool getGameOver()
    {
        return gameOver;
    }

    public void setEnemyCount(int e)
    {
        enemyCount = e;
    }

    public void removeEnemy()
    {
        enemyCount--;
    }

    public int getEnemyCount()
    {
        return enemyCount;
    }

    public bool getWin()
    {
        return isWin;
    }  
    
    public void setWin()
    {
        isWin = true;
    }

}

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
    public bool isVuln = true;
    public bool shield = false;

    private int enemyCount;
    private bool level3_speedPowerup = false;
    private bool halfSpeedProjectiles = false;
    private bool minimize = false;
    private bool attackUp = false;

    public Transform l3_target;

    private bool paused = false;
    private float volume = 1.0f;

    //any persistent data between scenes can be saved here
    //ship health, lives, score, game over and booleans
    //settings??

    private void Awake()
    {
        load();
        setVuln();
        stopShield();
    }

    private void load()
    {
        setVuln();
        stopShield();

        if (instance != null)
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
        setVuln();
        stopShield();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setScore(int s)
    {
        score += s;
    }

    public void resetScore()
    {
        score = 0;
    }

    public void resetPlayerVars()
    {
        //we might want to change these or set them to vars we can adjust elsewhere
        score = 0;
        lives = 3;
        shipHealth = 100;
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

    public void resetTime()
    {
        Time.timeScale = 1f;
    }

    public void halfSpeed()
    {
        halfSpeedProjectiles = true;
    }

    public void fullSpeed()
    {
        halfSpeedProjectiles = false;
    }

    public bool getHalfSpeed()
    {
        return halfSpeedProjectiles;
    }

    public void speedPowerup()
    {
        level3_speedPowerup = true;
    }

    public void speedPowerupRevert()
    {
        level3_speedPowerup = false;
    }

    public bool getSpeedPowerup()
    {
        return level3_speedPowerup;
    }

    public Transform getTarget_l3()
    {
        return l3_target;
    }

    public bool getVuln()
    {
        return isVuln;
    }

    public void setInvuln()
    {
        isVuln = false;
    }

    public void setVuln()
    {
        isVuln = true;
    }

    public bool getShield()
    {
        return shield;
    }

    public void setShield()
    {
        shield = true;
    }

    public void stopShield()
    {
        shield = false;
    }

    public void miniSized()
    {
        minimize = true;
    }

    public void normalSized()
    {
        minimize = false;
    }

    public bool isMinimized()
    {
        return minimize;
    }

    public void attackIncrease()
    {
        attackUp = true;
    }

    public void attackNormal()
    {
        attackUp = false;
    }

    public bool isAttackUp()
    {
        return attackUp;
    }

    public float getVol()
    {
        return volume;
    }

    public void setVol(float v)
    {
        volume = v;
    }

    public bool getPaused()
    {
        return paused;
    }

    public void togglePaused()
    {
        if(paused == true)
        {
            paused = false;
        }
        else
        {
            paused = true;
        }
    }
}

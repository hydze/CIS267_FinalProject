using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemySpawner : MonoBehaviour
{
    public GameObject[] spawnSpotsWave1;
    public GameObject[] enemyListWave1;

    public GameObject[] spawnSpotsWave2;
    public GameObject[] enemyListWave2;

    public int waveCount = 1;

    private int enemyCount;

    // Start is called before the first frame update
    void Start()
    {
       GameManager.instance.setEnemyCount(spawnSpotsWave1.Length);

        for (int i = spawnSpotsWave1.Length - 1; i >= 0; i--)
        {
            //place an enemy at our spawnSpots
            int randBlock = Random.Range(0, enemyListWave1.Length);
            Instantiate(enemyListWave1[randBlock], new Vector2(spawnSpotsWave1[i].transform.position.x, spawnSpotsWave1[i].transform.position.y), Quaternion.identity);
        }
    }

    void Update()
    {
      
        if(GameManager.instance.getEnemyCount() <= 0)
        {
            waveCount--;

            //wave over in reality and we should start wave 2 but doing as game over for now/testing


            if(waveCount > 0) //if we wanted really different things to happen in different waves we could set other ifs for other wave #s with different arrays of spots/enemies
            {
                GameManager.instance.setEnemyCount(spawnSpotsWave2.Length);

                for (int i = spawnSpotsWave2.Length - 1; i >= 0; i--)
                {
                    //place an enemy at our spawnSpots
                    int randBlock = Random.Range(0, enemyListWave2.Length);
                    Instantiate(enemyListWave2[randBlock], new Vector2(spawnSpotsWave2[i].transform.position.x, spawnSpotsWave2[i].transform.position.y), Quaternion.identity);
                }
            }
        }
        if(GameManager.instance.getEnemyCount() <= 0 && waveCount <= 0) //we cleared the level
        {
            GameManager.instance.setGameOver();
            GameManager.instance.setWin();
            SceneManager.LoadScene("GameOver"); //should load next level or win screen at end of last level or whatever when we add them
        }
    }


}

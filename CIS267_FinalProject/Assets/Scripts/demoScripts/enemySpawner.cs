using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemySpawner : MonoBehaviour
{
    public GameObject[] spawnSpots;
    public GameObject[] enemyList;

    private int enemyCount;

    // Start is called before the first frame update
    void Start()
    {
       GameManager.instance.setEnemyCount(spawnSpots.Length);

        for (int i = spawnSpots.Length - 1; i >= 0; i--)
        {
            //place an enemy at our spawnSpots
            int randBlock = Random.Range(0, enemyList.Length);
            Instantiate(enemyList[randBlock], new Vector2(spawnSpots[i].transform.position.x, spawnSpots[i].transform.position.y), Quaternion.identity);
        }
    }

    void Update()
    {
      
        if(GameManager.instance.getEnemyCount() == 0)
        {
            //wave over in reality and we should start wave 2 but doing as game over for now/testing
            GameManager.instance.setGameOver();
            GameManager.instance.setWin();
            SceneManager.LoadScene("GameOver");
        }
    }


}

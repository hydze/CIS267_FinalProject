using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    public GameObject[] spawnSpots;
    public GameObject[] enemyList;

    // Start is called before the first frame update
    void Start()
    {
        //!!!TODO!!!record spawnSpots.Length to know how many enemies there are so we know when they are gone, maybe a static gameinfo type class


        for (int i = spawnSpots.Length - 1; i >= 0; i--)
        {
            //place an enemy at our spawnSpots
            int randBlock = Random.Range(0, enemyList.Length);
            Instantiate(enemyList[randBlock], new Vector2(spawnSpots[i].transform.position.x, spawnSpots[i].transform.position.y), Quaternion.identity);
        }
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyInfo : MonoBehaviour
{

    public float health;
    public int points;

    public GameObject[] powerUps;
    public int chance;

    public bool hasPowerUps;

    public GameObject explosionPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        checkHealth();
    }

    void checkHealth()
    {
        if (health <= 0)
        {
            if(Random.Range(0, chance) == 0) //we roll for powerup here
            {
                if (powerUps.Length > 0)
                {
                    int randPow = Random.Range(0, powerUps.Length); //we choose here
                    Instantiate(powerUps[randPow], new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
                }
            }

            GameManager.instance.setScore(points);
            GameManager.instance.removeEnemy();
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
         
        }
    }

    public void deductHealth(float damage)
    {
        health -= damage;
    }
}

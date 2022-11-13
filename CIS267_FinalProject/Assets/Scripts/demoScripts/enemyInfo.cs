using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyInfo : MonoBehaviour
{

    public float health;
    public int points;

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
            GameManager.instance.setScore(points);
            GameManager.instance.removeEnemy();

            Destroy(this.gameObject);
         
        }
    }

    public void deductHealth(float damage)
    {
        health -= damage;
    }
}

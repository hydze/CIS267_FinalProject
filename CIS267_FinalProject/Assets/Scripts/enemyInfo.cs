using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyInfo : MonoBehaviour
{

    public float health;

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
            Destroy(this.gameObject);
        }
    }

    public void deductHealth(float damage)
    {
        health -= damage;
    }
}

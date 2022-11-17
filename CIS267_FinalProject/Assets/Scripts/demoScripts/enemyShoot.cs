using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShoot : MonoBehaviour
{
    public GameObject projectile;
    public Transform tip;

    public int delay;
    public int rate;
    public int fuzz;
    
    // Start is called before the first frame update
    void Start()
    {
        float fuzzTime = Random.Range(0.0f, fuzz);
        InvokeRepeating("shootWeapon", delay + fuzzTime, rate + fuzzTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void shootWeapon()
    {
        Instantiate(projectile, tip.position, transform.rotation);
    }
}

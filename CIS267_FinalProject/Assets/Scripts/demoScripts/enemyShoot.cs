using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShoot : MonoBehaviour
{
    public GameObject projectile;
    public Transform tip;

    public int delay;
    public int rate;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("shootWeapon", delay, rate);
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

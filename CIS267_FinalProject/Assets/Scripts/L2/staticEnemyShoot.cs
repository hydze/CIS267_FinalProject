using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class staticEnemyShoot : MonoBehaviour
{
    public GameObject circlePew;
    public Transform wing1;
    public Transform wing2;

    private staticShooterMovement shoot;

    public int delay;
    public int rate;
    public int fuzz;
    private bool wing = false;

    // Start is called before the first frame update
    void Start()
    {
        shoot = GetComponent<staticShooterMovement>();

        float fuzzTime = Random.Range(0.0f, fuzz);
        InvokeRepeating("shootWeapon", delay + fuzzTime, rate + fuzzTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void shootWeapon()
    {
        if(!wing)
        {
            shoot.makeMove();
            Instantiate(circlePew, wing1.position, transform.rotation);
            wing = true;
        }
        else
        {
            shoot.makeMove();
            Instantiate(circlePew, wing2.position, transform.rotation);
            wing = false;
        }
    }
}

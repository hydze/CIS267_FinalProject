using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireWeapon : MonoBehaviour
{

    public GameObject projectile;

    public Transform tip;

    private float timeBetweenShots;

    public float firingRate;

    private bool canFire = true;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //can player shoot weapon
        if (timeBetweenShots <= 0)
        {
            timeBetweenShots = firingRate;
            canFire = true;
        }
        else
        {
            timeBetweenShots -= Time.deltaTime;
        }


        if (Input.GetKeyDown(KeyCode.Space) || Input.GetButton("Fire1") || Input.GetButton("Fire2") || Input.GetButton("Fire3")) //probably a cleaner way to do gamepad shoot
        {
            if (canFire)
            {
                shootWeapon();
                canFire = false;
            }
        }

    }

    void shootWeapon()
    {
        Instantiate(projectile, tip.position, transform.rotation);
    }

}

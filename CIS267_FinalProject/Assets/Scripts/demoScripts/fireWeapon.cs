using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireWeapon : MonoBehaviour
{

    private AudioSource theShip;
    public AudioClip weapSound;

    public GameObject projectile;

    public Transform tip;

    private float timeBetweenShots;

    public float firingRate;

    public bool canFire = true;


    // Start is called before the first frame update
    void Start()
    {
        theShip = GameObject.FindWithTag("Ship").GetComponent<AudioSource>();
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
                if(weapSound != null && theShip != null)
                {
                    theShip.PlayOneShot(weapSound);
                }
                canFire = false;
            }
        }

    }

    void shootWeapon()
    {
        Instantiate(projectile, tip.position, transform.rotation);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fireWeapon : MonoBehaviour
{

    private AudioSource theShip;

    public AudioClip weapSound;
    public AudioClip weapSound2;
    public AudioClip weapSound3;

    public GameObject projectile;

    public Transform tip;

    private float timeBetweenShots;

    public float firingRate;

    public bool canFire = true;

    private screenShake mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        theShip = GameObject.FindWithTag("Ship").GetComponent<AudioSource>();
        mainCamera = GameObject.FindWithTag("MainCamera").GetComponent<screenShake>();
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
            if (canFire && !GameManager.instance.getPaused())
            {
                int rand = Random.Range(1, 4);
                shootWeapon();
                if(weapSound != null && theShip != null)
                {
                    if(SceneManager.GetActiveScene().name == "Level3")
                    {
                        if(rand == 1)
                        {
                            theShip.PlayOneShot(weapSound);
                        } else if(rand == 2)
                        {
                            theShip.PlayOneShot(weapSound2);
                        }
                        else
                        {
                            theShip.PlayOneShot(weapSound3);
                        }
                    }
                    else
                    {
                        theShip.PlayOneShot(weapSound);
                    }
                }
                canFire = false;
            }
        }

    }

    void shootWeapon()
    {
        if(mainCamera != null)
        {
            mainCamera.makeShake();
        }
        Instantiate(projectile, tip.position, transform.rotation);
    }

}

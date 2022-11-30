using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DemoGun2 : MonoBehaviour
{

    private AudioSource theShip;

    public AudioClip weapSound;
    public AudioClip weapSound2;
    public AudioClip weapSound3;

    public AudioClip weaponTooHot;
    public AudioClip weaponResetting;

    public GameObject projectile;

    public Transform tip;

    private float timeBetweenShots;
    float startTime;

    public float firingRate;

    public bool canFire = true;
    private bool canCount = true;
    private bool cooldownFire = false;
    private bool heldDown = false;

    private screenShake mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        startTime = 0f;
        theShip = GameObject.FindWithTag("Ship").GetComponent<AudioSource>();
        mainCamera = GameObject.FindWithTag("MainCamera").GetComponent<screenShake>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!cooldownFire)
        {
            cooldownChecker();
        }


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
            if (!cooldownFire && canFire && !GameManager.instance.getPaused())
            {
                int rand = Random.Range(1, 4);
                shootWeapon();
                if (weapSound != null && theShip != null)
                {
                    if (SceneManager.GetActiveScene().name == "Level3")
                    {
                        if (rand == 1)
                        {
                            theShip.PlayOneShot(weapSound);
                        }
                        else if (rand == 2)
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

    void cooldownChecker()
    {
       if(canCount)
        {
            cooldownCheckerFix();
        }




        if (!Input.GetKey(KeyCode.Space) && !Input.GetButton("Fire1") && !Input.GetButton("Fire2") && !Input.GetButton("Fire3"))
        {
            startTime = 0;
            Debug.Log("got where im not supposed to be");
            canCount = true;
            heldDown = false;
        }

        if (Time.time - startTime > 4f && heldDown)
            {
                startTime = 0;
                cooldownFire = true;
                theShip.PlayOneShot(weaponTooHot);
                Invoke("ResetHotness", 4);
            }

    }

    void cooldownCheckerFix()
    {
        if (Input.GetKey(KeyCode.Space) || Input.GetButton("Fire1") || Input.GetButton("Fire2") || Input.GetButton("Fire3") && canCount == true)
        {
            startTime = Time.time;
            Debug.Log(canCount);
            canCount = false;
            Debug.Log(canCount);
            heldDown = true;
        }
    }

    void shootWeapon()
    {
        if (mainCamera != null)
        {
            mainCamera.makeShake();
        }
        Instantiate(projectile, tip.position, transform.rotation);
    }

    void ResetHotness()
    {
        cooldownFire = false;
        theShip.PlayOneShot(weaponResetting);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enableShield : MonoBehaviour
{
    private AudioSource theShip;
    public AudioClip shieldSound;

    private GameObject shield;

    private bool shieldLock = false;
    public float shieldTime = 5;

    // Start is called before the first frame update
    void Start()
    {
        GameManager.instance.stopShield();
        theShip = GetComponent<AudioSource>();
        shield = GameObject.FindWithTag("L2ShieldOn");

    }

    // Update is called once per frame
    void Update()
    {
        if(!GameManager.instance.getVuln() && GameManager.instance.getShield() && !shieldLock)
        {
            theShip.PlayOneShot(shieldSound);
            shield.GetComponent<SpriteRenderer>().enabled = true;
            Invoke("stopShield", shieldTime);
            shieldLock = true;
        }
    }

    private void stopShield()
    {
        theShip.PlayOneShot(shieldSound);
        GameManager.instance.setVuln();
        GameManager.instance.stopShield();
        shield.GetComponent<SpriteRenderer>().enabled = false;
        shieldLock = false;

    }
}

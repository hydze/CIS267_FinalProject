using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldPowerup : MonoBehaviour
{
    public static ShieldPowerup instance;

    private AudioSource theShip;
    public AudioClip shieldGain, shieldBreak;
    public AudioClip[] shieldHit;

    public GameObject shield;

    public bool isActive;

    void Start()
    {
        instance = this;
        isActive = false;
        shield.SetActive(false);
        theShip = GetComponent<AudioSource>();
    }

    public void activateShield()
    {
        shield.SetActive(true);
        theShip.PlayOneShot(shieldGain);
        isActive = true;
        ShieldItself.instance.resetHealth();
    }

    void disableShield()
    {
        shield.SetActive(false);
        theShip.PlayOneShot(shieldBreak);
        isActive = false;
    }
    public bool isShieldActive()
    {
        return isActive;
    }

    public void playShieldHit()
    {
        if (ShieldItself.instance.health > 0)
        {
            if (shieldHit.Length > 0)
            {
                int randObj = Random.Range(0, shieldHit.Length);
                theShip.PlayOneShot(shieldHit[randObj]);
            }
        } else
        {
            disableShield();
        }
    }
}

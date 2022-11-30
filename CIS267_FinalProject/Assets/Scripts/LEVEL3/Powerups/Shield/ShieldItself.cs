using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldItself : MonoBehaviour
{
    public static ShieldItself instance;

    public int health;
    private int tempHealth;

    private void Start()
    {
        instance = this;
        tempHealth = health;
    }

    private void Update()
    {
        if (!this.gameObject.activeSelf)
        {
            tempHealth = health;
        }
    }

    public void hitShield()
    {
        health--;
        ShieldPowerup.instance.playShieldHit();
    }

    public void resetHealth()
    {
        health = tempHealth;
    }

}

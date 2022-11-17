using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class changeWeapon : MonoBehaviour
{
    public Transform RWeapon;
    public Transform LWeapon;
    public GameObject[] myWeapons;

    private int podNum; //can always add more pods or whatever too

    private int theWeapon = 0; //the weapon you spawn with put in slot 1 (right spot)

    // Start is called before the first frame update
    void Start()
    {
        GameObject spawnWeapon = myWeapons[theWeapon];
        Instantiate(spawnWeapon, RWeapon);
        podNum = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void swapWeapon(int weaponID)
    {
        if(podNum == 1)
        {
            if(LWeapon.childCount > 0) //we dont want weapons stacking, we swap when we pick up
            {
                Destroy(LWeapon.GetChild(0).gameObject);
            }
            GameObject newWeap = myWeapons[weaponID];
            Instantiate(newWeap, LWeapon);
            podNum = 2;
        }
        else
        {
            if (RWeapon.childCount > 0)
            {
                Destroy(RWeapon.GetChild(0).gameObject);
            }
            GameObject newWeap = myWeapons[weaponID];
            Instantiate(newWeap, RWeapon);
            podNum = 1;
        }


    }

    private void OnTriggerEnter2D(Collider2D collision) //weapon tags should correspond to what you want in the public array myWeapons
    {
        if (collision.gameObject.CompareTag("weap1"))
        {
            swapWeapon(0);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("weap2"))
        {
            swapWeapon(1);
            Destroy(collision.gameObject);
        }
    }


}

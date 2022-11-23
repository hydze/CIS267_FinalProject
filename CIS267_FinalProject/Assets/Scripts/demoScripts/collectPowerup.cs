using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class collectPowerup : MonoBehaviour
{
    private AudioSource theShip;
    public AudioClip slowDown;

    private float time;
    public float slowPowTime = 10;

    // Start is called before the first frame update
    void Start()
    {
        theShip = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.instance.getHalfSpeed())
        {

            time = time + 1f * Time.deltaTime;
          
            if (time > slowPowTime)
            {
               time = 0f;
               GameManager.instance.fullSpeed();       
            }

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("L2Clock"))
        {
            theShip.PlayOneShot(slowDown);
            GameManager.instance.halfSpeed();
            Destroy(collision.gameObject);
        }
    }

    
}

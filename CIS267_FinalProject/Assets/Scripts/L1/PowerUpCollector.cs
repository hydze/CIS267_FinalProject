using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpCollector : MonoBehaviour
{
    private AudioSource theShip;
    public AudioClip clip;
    private float time;
    public float powerUpTimer;
    // Start is called before the first frame update
    void Start()
    {
        theShip = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.isMinimized())
        {
            time = time + 1f * Time.deltaTime;

            if (time > powerUpTimer)
            {
                time = 0f;
                GameManager.instance.normalSized();
                gameObject.transform.localScale = new Vector3(1f, 1f, 0);
            }
        }

        if (GameManager.instance.isAttackUp())
        {
            time = time + 1f * Time.deltaTime;

            if (time > powerUpTimer)
            {
                time = 0f;
                GameManager.instance.attackNormal();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //ship mini sized
        if (collision.gameObject.CompareTag("Mini"))
        {
            theShip.PlayOneShot(clip);
            Destroy(collision.gameObject);
        }

        //ENEMY attack up + 5 :)
        if (collision.gameObject.CompareTag("Attack"))
        {
            GameManager.instance.attackIncrease();
            theShip.PlayOneShot(clip);
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("weap1"))
        {
            theShip.PlayOneShot(clip);
        }
        if (collision.gameObject.CompareTag("weap2"))
        {
            theShip.PlayOneShot(clip);
        }
    }
}

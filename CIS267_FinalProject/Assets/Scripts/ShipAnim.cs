using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShipAnim : MonoBehaviour
{
    private Animator anim;

    private AudioSource theShip;
    public AudioClip[] shipHit;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        theShip = GetComponent<AudioSource>();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(SceneManager.GetActiveScene().name == "Level3")
        {
            if(!ShieldPowerup.instance.isShieldActive())
            {
                if (collision.gameObject.CompareTag("enemyProjectile") || collision.gameObject.CompareTag("Enemy"))
                {
                    if (GameManager.instance.getVuln())
                    {
                        if (shipHit.Length > 0)
                        {
                            int randObj = Random.Range(0, shipHit.Length);
                            theShip.PlayOneShot(shipHit[randObj]);
                        }

                        anim.SetBool("damageBlink", true);
                        Invoke("stopBlink", 1f);
                    }
                }
            }
        }

        else if (collision.gameObject.CompareTag("enemyProjectile") || collision.gameObject.CompareTag("Enemy"))
        {
            if (GameManager.instance.getVuln())
            {
                if (shipHit.Length > 0)
                {
                    int randObj = Random.Range(0, shipHit.Length);
                    theShip.PlayOneShot(shipHit[randObj]);
                }

                anim.SetBool("damageBlink", true);
                Invoke("stopBlink", 1f);
            }
        }
    }

    private void stopBlink()
    {
        anim.SetBool("damageBlink", false);
    }
}

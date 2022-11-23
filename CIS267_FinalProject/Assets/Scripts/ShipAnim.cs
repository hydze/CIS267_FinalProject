using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipAnim : MonoBehaviour
{
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("enemyProjectile") || collision.gameObject.CompareTag("Enemy"))
        {
            anim.SetBool("damageBlink", true);
            Invoke("stopBlink", 1f);
        }
    }

    private void stopBlink()
    {
        anim.SetBool("damageBlink", false);
    }
}

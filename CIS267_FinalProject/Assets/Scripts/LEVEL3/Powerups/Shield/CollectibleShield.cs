using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleShield : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ship") || collision.gameObject.CompareTag("Border"))
        {
            if (collision.gameObject.CompareTag("Ship"))
            {
                ShieldPowerup.instance.activateShield();
            }
            Destroy(this.gameObject);
        }
    }
}

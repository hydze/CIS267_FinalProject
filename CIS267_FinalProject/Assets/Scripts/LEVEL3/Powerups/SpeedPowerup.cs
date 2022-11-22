using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPowerup : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ship") || collision.gameObject.CompareTag("Border"))
        {
            if(collision.gameObject.CompareTag("Ship"))
            {
                GameManager.instance.speedPowerup();
            }
            Destroy(this.gameObject);
        }
    }
}

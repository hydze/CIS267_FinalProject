using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniPowerUp : MonoBehaviour
{
    private float time;
    // Start is called before the first frame update
    void Start()
    {
        //power up minimizes the ship and halfs ship projectile damage for 5 seconds
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Ship"))
        {
            collision.gameObject.transform.localScale = new Vector3(0.5f, 0.5f, 0);
            GameManager.instance.miniSized();
        }
    }
}

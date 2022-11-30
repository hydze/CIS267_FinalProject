using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncingBugs : MonoBehaviour
{
    public Rigidbody2D rb;
    int tempGrav;

    private void Start()
    {
        tempGrav = ((int)rb.gravityScale);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("nopastthis"))
        {
            rb.gravityScale = -0.01f;
        }
        else if (collision.gameObject.CompareTag("nonononotpastthis"))
        {
            rb.gravityScale = 0.01f;
        }
    }

}

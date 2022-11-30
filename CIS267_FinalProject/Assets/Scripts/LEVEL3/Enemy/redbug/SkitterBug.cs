using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkitterBug : MonoBehaviour
{
    public bool canSkitter = true;
    public bool invokeTimer = false;
    public Rigidbody2D rb;
    public float speed;

    private void FixedUpdate()
    {
        if (canSkitter)
        {
            skitter();
        }
        if(!canSkitter)
        {
            flip();
        }
    }

    void skitter()
    {
        canSkitter = true;

        rb.velocity = new Vector2(speed * Time.fixedDeltaTime, rb.velocity.y);

        if (canSkitter && !invokeTimer)
        {
            Invoke("flip", 1);
            invokeTimer = true;
        }
    }

    void flip()
    {
        canSkitter = false;
        transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
        speed *= -1;

        if (!canSkitter && invokeTimer)
        {
            Invoke("resetSkitterTimer", 1);
            invokeTimer = false;
        }
    }

    void resetSkitterTimer()
    {
        canSkitter = true;
    }

}

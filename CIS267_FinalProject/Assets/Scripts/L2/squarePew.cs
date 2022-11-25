//using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class squarePew : MonoBehaviour
{
    public float projectileDamage;
    public float projectileTTL;

    public float pewTime = 1;
    public float moveSpeed = 1;
    private int pewMove = 0;
    private bool dir = true;


    private float moveTime;


    private float realSpeed;

    // Start is called before the first frame update
    void Start()
    {
        moveSpeed += Random.Range(0.0f, 1);

        if (Random.Range(0, 200) > 100)
        {
            dir = false;
            pewMove = 3;
        }

        Invoke("destroyProjectile", projectileTTL);
    }

    // Update is called once per frame
    void Update()
    {
        moveTime = moveTime + 1f * Time.deltaTime;

        if (moveTime < pewTime)
        {
            realSpeed = moveSpeed;

            if (GameManager.instance.getHalfSpeed())
            {
                realSpeed = moveSpeed / 3;
            }

            if (pewMove == 0)
            {
                squarePewD();
            }
            if (pewMove == 1)
            {
                if(dir == true)
                {
                   squarePewL();
                }
                else
                {
                    squarePewR();
                }
            }
            if (pewMove == 2)
            {
                squarePewD();
            }
            if (pewMove == 3)
            {
                if (dir == true)
                {
                    squarePewD();
                }
                else
                {
                    squarePewL();
                }
            }



        }
        if (moveTime > pewTime)
        {
            pewMove++;
            if (pewMove > 3)
            {
                pewMove = 0;
            }
            moveTime = 0;
        }

    }




public void squarePewL()
    {
        transform.Translate(Vector3.left * realSpeed * Time.deltaTime, Space.World);
    }

    public void squarePewR()
    {
        transform.Translate(Vector3.right * realSpeed * Time.deltaTime, Space.World);
    }

    public void squarePewD()
    {
        transform.Translate(Vector3.down * realSpeed * Time.deltaTime, Space.World);
    }

    void destroyProjectile()
    {
        Destroy(this.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ship"))
        {
            if (GameManager.instance.getVuln())
            {
                GameManager.instance.removeHealth((int)projectileDamage);
            }
            destroyProjectile();
        }
    }

}

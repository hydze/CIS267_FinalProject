using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.VisualScripting.Member;

public class enemySquareDance : MonoBehaviour
{
    
    public float danceTime = 1;
    public float moveSpeed = 1;
    private int danceMove = 0;
    private bool dir = false;

    public float delay;
    private float time;
    private float moveTime;

    public int fuzz;
    private bool started = false;
    private float realSpeed;

    // Start is called before the first frame update
    void Start()
    {
        delay += Random.Range(0.0f, fuzz);

        if(Random.Range(0, 200) > 100)
        {
            dir = true;
            danceMove = 3;
        }

    }

    // Update is called once per frame
    void Update()
    {
        time = time + 1f * Time.deltaTime;
        if (started == false)
        {
            if (time > delay)
            {

                started = true;
            }
        }
        else
        {
            moveTime = moveTime + 1f * Time.deltaTime;

                if (moveTime < danceTime)
                {
                     realSpeed = moveSpeed;

                     if (GameManager.instance.getHalfSpeed())
                     {
                         realSpeed = moveSpeed / 3;
                     }

                if (danceMove == 0)
                {
                    squareDanceL();
                }
                if (danceMove == 1)
                {
                    squareDanceU();
                }
                if (danceMove == 2)
                {
                    squareDanceR();
                }
                if (danceMove == 3)
                {
                    squareDanceD();
                }

                }
                if(moveTime > danceTime)
                {
                    if (dir == false)
                    {
                        danceClockwise();
                    }
                    else
                    {
                        danceCounterClockwise();
                    }
                    moveTime = 0;
                }

        }
            
        
    }

    public void squareDanceL()
    {
        transform.Translate(Vector3.left * realSpeed * Time.deltaTime, Space.World);
    }

    public void squareDanceR()
    {
        transform.Translate(Vector3.right * realSpeed * Time.deltaTime, Space.World);
    }

    public void squareDanceD()
    {
        transform.Translate(Vector3.down * realSpeed * Time.deltaTime, Space.World);
    }

    public void squareDanceU()
    {
        transform.Translate(Vector3.up * realSpeed * Time.deltaTime, Space.World);
    }


    public void danceClockwise()
    {
        danceMove++;

        if (danceMove == 4)
        {
            danceMove = 0;
        }
    }

    public void danceCounterClockwise()
    {
        danceMove--;

        if (danceMove < 0)
        {
            danceMove = 3;
        }
    }
}

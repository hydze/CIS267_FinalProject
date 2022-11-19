//using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class chaseShip : MonoBehaviour
{
    public Transform ship;
    private Rigidbody2D enemyRB;
    private Vector2 movement;

    public float moveSpeed;
    public float maxDistance;
    public float minDistance;

    public float delay;
    private float time;
    public int fuzz;

    private bool started = false;


    // Start is called before the first frame update
    void Start()
    {
        enemyRB = GetComponent<Rigidbody2D>();
        Vector3 dir = ship.position - transform.position;

        delay += Random.Range(0.0f, fuzz);
        
    }

    // Update is called once per frame
    void Update()
    {
        time = time + 1f * Time.deltaTime;
        if(started == false)
        {
            if(time > delay)
            {
                started = true;
            }
        }
        else
        {
            followShip();
        }

    }


    public void aimAtShip()
    {
        Vector3 dir = ship.position - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        enemyRB.rotation = angle;
    }

    public void followShip()
    {
        Vector3 dir = ship.position - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        enemyRB.rotation = angle;
        dir.Normalize();
        enemyRB.MovePosition(transform.position + (dir * moveSpeed * Time.deltaTime));
    }


}

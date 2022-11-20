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

    public float ramDamage;
    public float moveSpeed = 3;

    public GameObject explosionPrefab;

    public float delay;
    private float time;
    public int fuzz;

    private bool started = false;


    // Start is called before the first frame update
    void Start()
    {
        enemyRB = GetComponent<Rigidbody2D>();
        ship = GameObject.FindWithTag("Ship").transform; 
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
        float realSpeed = moveSpeed;
        enemyRB.rotation = angle;
        dir.Normalize();
        if (GameManager.instance.getHalfSpeed())
        {
            realSpeed = moveSpeed / 3;
        }
        enemyRB.MovePosition(transform.position + (dir * realSpeed * Time.deltaTime));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ship"))
        {
            GameManager.instance.removeEnemy();
            GameManager.instance.removeHealth((int)ramDamage);
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }

}

//using System;
using System.Collections;
using System.Collections.Generic;
//using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class chaseShip : MonoBehaviour
{
    private Transform ship;
    private Rigidbody2D enemyRB;
    private Vector2 movement;

    public float ramDamage;
    public float moveSpeed = 3;

    public GameObject explosionPrefab;

    public float delay;
    private float time;
    public int fuzz;

    private bool started = false;

    public AudioSource source;
    public AudioClip powOn;

    public AudioClip pop0;
    public AudioClip pop1;
    public AudioClip pop2;

    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        enemyRB = GetComponent<Rigidbody2D>();
        ship = GameObject.FindWithTag("Ship").transform;
        animator = GetComponentInChildren<Animator>();
        delay += Random.Range(0.0f, fuzz);
        
    }

    // Update is called once per frame
    void Update()
    {
        int trigger = Random.Range(0, 200);

        time = time + 1f * Time.deltaTime;
        if(started == false)
        {
            if(time > delay)
            {
                source.PlayOneShot(powOn);
                started = true;
                if (animator != null)
                {
                    animator.SetTrigger("Wake"); //wake up/look around 
                }
            }
        }
        else
        {
            if (animator != null && trigger > 199)
            {
                animator.SetTrigger("Wake"); //look around/reaquire target 
            }
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

            if (GameManager.instance.getVuln())
            {
                GameManager.instance.removeHealth((int)ramDamage);
            }

            //gameObject.GetComponentInChildren<SpriteRenderer>().enabled = false;
            gameObject.GetComponent<Collider2D>().enabled = false;

            if (animator != null)
            {
                animator.Play("death"); //buh bye
            }



            Invoke("explode", .4f);
            Destroy(this.gameObject, .6f);
        }
    }

    public void explode()
    {
        int pop = Random.Range(0, 3);

        if (pop == 0)
        {
            source.PlayOneShot(pop0);
        }
        else if (pop == 1)
        {
            source.PlayOneShot(pop1);
        }
        else if (pop == 2)
        {
            source.PlayOneShot(pop2);
        }

        //gameObject.GetComponentInChildren<SpriteRenderer>().enabled = false;
        Instantiate(explosionPrefab, transform.position, Quaternion.identity);
    }

}

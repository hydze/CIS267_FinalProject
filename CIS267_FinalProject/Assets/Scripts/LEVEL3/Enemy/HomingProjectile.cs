using System.Collections;
using System.Collections.Generic;
//using UnityEditor.Experimental.GraphView;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class HomingProjectile : MonoBehaviour
{
    private Transform ship;
    private Rigidbody2D rb;
    public GameObject explosion;
    public float moveSpeed;
    public float rotateSpeed;

    public int damageAmt;
    public float delay;
    private float time;
    private bool started = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ship = GameObject.FindWithTag("Ship").transform;

    }
    void FixedUpdate()
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
            rb.gravityScale = 18f;
            followShip();
        }

    }

    public void aimAtShip()
    {
        Vector3 dir = ship.position - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
    }

    void followShip()
    {
        Vector3 dir = ship.position - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        float realSpeed = moveSpeed;
        rb.rotation = angle;
        dir.Normalize();
        if (GameManager.instance.getHalfSpeed())
        {
            realSpeed = moveSpeed / 3;
        }
        rb.MovePosition(transform.position + (dir * realSpeed * Time.deltaTime));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ship"))
        {
            GameManager.instance.removeEnemy();
            GameManager.instance.removeHealth((int)damageAmt);
            Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
 
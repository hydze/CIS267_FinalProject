using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveAstroid : MonoBehaviour
{
    public float moveSpeed = 2;
    private float realSpeed;
    private AudioSource theShip;
    public AudioClip bulletHit;


    // Start is called before the first frame update
    void Start()
    {
        theShip = GameObject.FindWithTag("Ship").GetComponent<AudioSource>();

        Invoke("destroyAstroid", 35);
    }

    // Update is called once per frame
    void Update()
    {
        realSpeed = moveSpeed;
        if (GameManager.instance.getHalfSpeed())
        {
            realSpeed = moveSpeed / 3;
        }
        transform.Translate(Vector3.left * realSpeed * Time.deltaTime, Space.World);
    }


    private void destroyAstroid()
    {
        Destroy(this.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("enemyProjectile"))
        {
            //Debug.Log("enemyProjectile");
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("shipProjectile"))
        {
            theShip.PlayOneShot(bulletHit);
            //Debug.Log("shipProjectile");
            Destroy(collision.gameObject);
        }

    }
}

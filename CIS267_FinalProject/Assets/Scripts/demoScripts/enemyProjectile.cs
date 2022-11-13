using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyProjectile : MonoBehaviour
{
    public float projectileDamage;
    public float projectileSpeed;
    public float projectileTTL;


    // Start is called before the first frame update
    void Start()
    {
        Invoke("destroyProjectile", projectileTTL);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-transform.up * projectileSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ship"))
        {
            GameManager.instance.removeHealth((int)projectileDamage);
            destroyProjectile();
        }
    }



    void destroyProjectile()
    {
        Destroy(this.gameObject);
    }
}
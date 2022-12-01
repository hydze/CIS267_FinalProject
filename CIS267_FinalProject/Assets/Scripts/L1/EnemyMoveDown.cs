using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveDown : MonoBehaviour
{
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveDown();
    }

    private void moveDown()
    {
        transform.Translate(Vector2.down * moveSpeed * Time.deltaTime);

        if (transform.position.y < -5.5f)
        {
            //transform.position = new Vector2(transform.position.x, 5.5f);

            float xPos = Random.Range(-8f, 8f);
            transform.position = new Vector2(xPos, 5.5f);
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ship"))
        {
            if (GameManager.instance.getVuln())
            {
                GameManager.instance.removeHealth((5));
            }
        }
    }
}

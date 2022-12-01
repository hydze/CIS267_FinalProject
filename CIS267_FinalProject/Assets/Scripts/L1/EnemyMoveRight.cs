using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveRight : MonoBehaviour
{
    public float moveSpeed;
    private float time;
    public float timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveRight();
    }

    private void moveRight()
    {
        transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
        if (transform.position.x > 10)
        {
            transform.position = new Vector2(-10.0f, transform.position.y);
        }
    }
}

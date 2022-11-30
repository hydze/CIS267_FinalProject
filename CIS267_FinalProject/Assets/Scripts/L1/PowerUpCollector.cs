using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpCollector : MonoBehaviour
{
    private float time;
    public float powerUpTimer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.isMinimized())
        {
            time = time + 1f * Time.deltaTime;

            if (time > powerUpTimer)
            {
                time = 0f;
                GameManager.instance.normalSized();
                gameObject.transform.localScale = new Vector3(1f, 1f, 0);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Mini"))
        {
            Destroy(collision.gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipDeath : MonoBehaviour
{
    public Transform respawnPoint;
    public GameObject explosionPrefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        shipExplode();
    }

    private void shipExplode()
    {
        if (GameManager.instance.getHealth() <= 0)
        {
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Invoke("respawnDelay", 1f);
        }
    }

    private void respawnDelay()
    {
        transform.position = respawnPoint.position;
    }
}

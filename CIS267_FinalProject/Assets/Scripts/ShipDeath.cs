using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipDeath : MonoBehaviour
{
    public Transform respawnPoint;
    public GameObject explosionPrefab;

    private AudioSource theShip;
    public AudioClip shipBoom;

    // Start is called before the first frame update
    void Start()
    {
        theShip = GetComponent<AudioSource>();
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
            if(shipBoom != null && theShip != null)
            {
                theShip.PlayOneShot(shipBoom);
            }
            
            GameManager.instance.setInvuln();

            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Invoke("respawnDelay", .5f);
            GameManager.instance.removeLives(1); //moved this stuff here since the explosion/respawn wasnt always being picked up doing this all in 2 scripts
            GameManager.instance.setHealth(100);
        }
    }

    private void respawnDelay()
    {
        transform.position = respawnPoint.position;
        Invoke("moreSpawnInvulnTime", 1f);
    }

    private void moreSpawnInvulnTime()
    {
        GameManager.instance.setVuln();
    }
}

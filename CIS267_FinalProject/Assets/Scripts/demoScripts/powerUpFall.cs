using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUpFall : MonoBehaviour
{
    
    Rigidbody2D powerupRB;
    public int powerupSpeed = 3; //how quick do our powerups fall
 
    // Start is called before the first frame update
    void Start()
    {
        powerupRB = GetComponent<Rigidbody2D>();
        powerupRB.velocity = Vector2.down * powerupSpeed; //drop the powerup when its spawned
    }

    // Update is called once per frame
    void Update()
    {

    }
}

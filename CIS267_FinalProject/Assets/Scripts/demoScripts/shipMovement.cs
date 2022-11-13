using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

public class shipMovement : MonoBehaviour
{

    Rigidbody2D shipRB;

    public float moveSpeed;
    public float shipClipX; //adjust for ship

    private float inputX;

    // Start is called before the first frame update
    void Start()
    {
        shipRB = GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    void Update()
    {
        inputX = Input.GetAxisRaw("Horizontal");  //Think this should work for gamepad too?
    }


    private void FixedUpdate()
    {
        moveShip();
    }


    void moveShip()
    {

        if ((inputX > 0 && transform.position.x < shipClipX) || (inputX < 0 && transform.position.x > -shipClipX))
        {
            transform.position += Vector3.right * inputX * moveSpeed * Time.deltaTime;  //moveway is +/- 1 if pressed so positive or negative on the axis timedelta helps kinda like fixedupdate
        }
    }

}

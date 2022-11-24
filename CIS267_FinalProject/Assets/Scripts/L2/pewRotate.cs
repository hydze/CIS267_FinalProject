using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pewRotate : MonoBehaviour
{
    public bool dir = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(dir)
        {
            transform.RotateAround(transform.position, Vector3.forward, 120 * Time.deltaTime);

        }
        else
        {
            transform.RotateAround(transform.position, Vector3.back, 120 * Time.deltaTime);

        }
    }
}

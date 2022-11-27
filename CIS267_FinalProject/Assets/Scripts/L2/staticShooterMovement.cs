using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class staticShooterMovement : MonoBehaviour
{
    private float moveDur = .2f;
    private float shakeMag = .035f;
    public float dampner = 1;

    private Vector3 initialPosition;

    void Awake()
    {

    }

    private void OnEnable()
    {
        initialPosition = transform.localPosition;
    }
    // Update is called once per frame
    void Update()
    {
        if (moveDur > 0)
        {
            transform.localPosition = new Vector3(initialPosition.x, initialPosition.y + .025f, initialPosition.z);

            moveDur -= Time.deltaTime;
        }
        else
        {
            moveDur = 0f;
            transform.localPosition = initialPosition;
        }
    }

    public void makeMove()
    {
        moveDur = .1f;
    }





}
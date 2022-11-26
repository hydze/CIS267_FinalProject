using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screenShake : MonoBehaviour
{
    
    private float shakeDur = .25f;
    private float shakeMag = .025f;
    public float dampner;

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
        if (shakeDur > 0)
        {
            transform.localPosition = initialPosition + Random.insideUnitSphere * shakeMag;

            shakeDur -= Time.deltaTime * dampner;
        }
        else
        {
            shakeDur = 0f;
            transform.localPosition = initialPosition;
        }
    }

    public void makeShake()
    {
        shakeDur = .25f;
    }
}

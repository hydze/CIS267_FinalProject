using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.TimeZoneInfo;

public class enemyMoveSpawn : MonoBehaviour
{

    public Transform flyTo;
    private Transform startFrom;

    public float flyTime;
    private float time;

    // Start is called before the first frame update
    void Start()
    {
        startFrom = GetComponent<Transform>();
        transform.position = startFrom.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (time < flyTime)
        {
            transform.position = Vector3.Slerp(startFrom.position, flyTo.position, time / flyTime);
            time += Time.deltaTime;
        }
        else if (time >= flyTime)
        {
            transform.position = flyTo.position;
        }
    }
}

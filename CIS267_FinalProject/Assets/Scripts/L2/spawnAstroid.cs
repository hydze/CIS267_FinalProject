using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class spawnAstroid : MonoBehaviour
{
    public GameObject topY;
    public GameObject botY;

    public GameObject[] astroids;

    private int randomAstroid;
    private float time;
    public float delay = 10;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        //I only want to spawn a new object if there was a specified amount of time between the last time I spawned an object
        if (time >= delay)
        {
            spawnRoid();
            time = 0f;
        }
    }

    private void spawnRoid()
    {
        randomAstroid = Random.Range(0, astroids.Length);
        Instantiate(astroids[randomAstroid], new Vector2(botY.transform.position.x, Random.Range(botY.transform.position.y, topY.transform.position.y)), Quaternion.identity);
    }
}

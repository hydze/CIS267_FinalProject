using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.VisualScripting.Member;

public class enemyPather : MonoBehaviour
{
    GameObject[] weVisit;

    private int pos ;
    public float ourSpeed = .35f;

    public float delay;
    private float time;
    public int fuzz;
    public float speedFuzz = 1.5f;

    private bool started = false;
    private float realSpeed;

    private AudioSource source;
    public AudioClip powOn;

    // Start is called before the first frame update
    void Start()
    {
        weVisit = GameObject.FindGameObjectsWithTag("L2Spawns1");
        delay += Random.Range(0.0f, fuzz);
        ourSpeed += Random.Range(2f, speedFuzz);
        source = GameObject.FindWithTag("Ship").GetComponent<AudioSource>();
        pos = Random.Range(0, weVisit.Length);
    }

    // Update is called once per frame
    void Update()
    {
        time = time + 1f * Time.deltaTime;
        if (started == false)
        {
            if (time > delay)
            {
                source.PlayOneShot(powOn);
                started = true;
            }
        }
        else
        {
            moveThroughSpots();
        }
        
    }

    public void moveThroughSpots()
    {
        realSpeed = ourSpeed;

        if (GameManager.instance.getHalfSpeed())
        {
            realSpeed = ourSpeed / 3;
        }

        Transform spot = weVisit[pos].transform;

        if (Vector3.Distance(transform.position, spot.position) < 0.1f)
        {
            pos = Random.Range(0, weVisit.Length); //close enough go somewhere else
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, spot.position, realSpeed * Time.deltaTime);
        }
    }
}

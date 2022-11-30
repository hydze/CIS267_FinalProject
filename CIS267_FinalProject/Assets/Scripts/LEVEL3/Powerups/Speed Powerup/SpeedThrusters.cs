using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedThrusters : MonoBehaviour
{
    public static SpeedThrusters instance;

    private AudioSource theShip;
    public AudioClip collectStart;
    public AudioClip collectEnd;

    public GameObject thrusterLeft;
    public GameObject thrusterRight;
    public GameObject largeThruster;
    public GameObject normalThruster;

    private void Start()
    {
        theShip = GetComponent<AudioSource>();
        instance = this;
    }

    public void setThrusterActive()
    {
        thrusterLeft.SetActive(true);
        thrusterRight.SetActive(true);
        largeThruster.SetActive(true);
        normalThruster.SetActive(false);
        theShip.PlayOneShot(collectStart);
    }

    public void setThrusterInactive()
    {
        thrusterLeft.SetActive(false);
        thrusterRight.SetActive(false);
        largeThruster.SetActive(false);
        normalThruster.SetActive(true);
        theShip.PlayOneShot(collectEnd);
    }
}

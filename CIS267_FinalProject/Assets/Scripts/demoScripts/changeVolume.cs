using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeVolume : MonoBehaviour
{
    private Slider volSlide;

    // Start is called before the first frame update
    void Start()
    {
        volSlide = GetComponent<Slider>();
        volSlide.value = GameManager.instance.getVol();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeVol(float v)
    {
        AudioListener.volume = v;
        GameManager.instance.setVol(v);
    }
}

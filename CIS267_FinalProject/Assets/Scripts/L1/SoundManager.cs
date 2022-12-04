using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager smInstance;

    public AudioSource source;
    public AudioClip clip;

    private void Awake()
    {
        load();
    }

    private void load()
    {
        if (smInstance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            smInstance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}

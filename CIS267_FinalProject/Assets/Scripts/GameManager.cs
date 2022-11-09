using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int score;
    public int lives;
    public int shipHealth;
    public bool gameOver;
    //any persistent data between scenes can be saved here
    //ship health, lives, score, game over and booleans
    //settings??

    private void Awake()
    {
        load();
    }

    private void load()
    {
        if(instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

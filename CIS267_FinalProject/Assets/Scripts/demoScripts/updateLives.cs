using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class updateLives : MonoBehaviour
{
    private TextMeshProUGUI livesText;

    // Start is called before the first frame update
    void Start()
    {
        livesText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        livesText.SetText(GameManager.instance.getLives().ToString() + " : Lives");
    }
}

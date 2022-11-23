using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class updateHealth : MonoBehaviour
{
    private TextMeshProUGUI hpText;

    // Start is called before the first frame update
    void Start()
    {
        hpText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        hpText.SetText(GameManager.instance.getHealth().ToString() + " : HP");
  
    }
}

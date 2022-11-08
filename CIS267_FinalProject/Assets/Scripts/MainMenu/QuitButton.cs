using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class QuitButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject quitScreen;
    public void OnPointerEnter(PointerEventData eventData)
    {
        quitScreen.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        quitScreen.SetActive(false);
    }
}
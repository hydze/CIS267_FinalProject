using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject playScreen;
    public void OnPointerEnter(PointerEventData eventData)
    {
        playScreen.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        playScreen.SetActive(false);
    }
}
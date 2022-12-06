using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayButton : MonoBehaviour, ISelectHandler, IDeselectHandler, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject playScreen;

    public void OnSelect(BaseEventData eventData)
    {
        playScreen.SetActive(true);
    }

    public void OnDeselect(BaseEventData eventData)
    {
        playScreen.SetActive(false);
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        playScreen.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        playScreen.SetActive(false);
    }
}
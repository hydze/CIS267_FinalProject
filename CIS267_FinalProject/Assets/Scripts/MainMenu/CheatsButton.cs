using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CheatsButton : MonoBehaviour, ISelectHandler, IDeselectHandler, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject cheatsScreen;
    public void OnSelect(BaseEventData eventData)
    {
        cheatsScreen.SetActive(true);
    }

    public void OnDeselect(BaseEventData eventData)
    {
        cheatsScreen.SetActive(false);
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        cheatsScreen.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        cheatsScreen.SetActive(false);
    }
}
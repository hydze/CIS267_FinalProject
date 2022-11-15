using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CheatsButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject cheatsScreen;
    public void OnPointerEnter(PointerEventData eventData)
    {
        cheatsScreen.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        cheatsScreen.SetActive(false);
    }
}
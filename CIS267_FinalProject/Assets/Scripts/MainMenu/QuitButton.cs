using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class QuitButton : MonoBehaviour, ISelectHandler, IDeselectHandler, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject quitScreen;

    
    public void OnSelect(BaseEventData eventData)
    {
        quitScreen.SetActive(true);
    }

    private void OnMouseEnter()
    {
        quitScreen.SetActive(true);
    }

    public void OnDeselect(BaseEventData eventData)
    {
        quitScreen.SetActive(false);
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        quitScreen.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        quitScreen.SetActive(false);
    }
}
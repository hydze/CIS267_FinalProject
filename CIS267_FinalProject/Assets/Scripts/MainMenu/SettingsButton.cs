using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SettingsButton : MonoBehaviour, ISelectHandler, IDeselectHandler, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject settingsScreen;
    public void OnSelect(BaseEventData eventData)
    {
        settingsScreen.SetActive(true);
    }

    public void OnDeselect(BaseEventData eventData)
    {
        settingsScreen.SetActive(false);
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        settingsScreen.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        settingsScreen.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SettingsButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject settingsScreen;
    public void OnPointerEnter(PointerEventData eventData)
    {
        settingsScreen.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        settingsScreen.SetActive(false);
    }
}

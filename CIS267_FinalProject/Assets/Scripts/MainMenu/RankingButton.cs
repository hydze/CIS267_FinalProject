using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RankingButton : MonoBehaviour, ISelectHandler, IDeselectHandler, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject rankScreen;
    public void OnSelect(BaseEventData eventData)
    {
        rankScreen.SetActive(true);
    }

    public void OnDeselect(BaseEventData eventData)
    {
        rankScreen.SetActive(false);
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        rankScreen.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        rankScreen.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RankingButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject rankScreen;
    public void OnPointerEnter(PointerEventData eventData)
    {
        rankScreen.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        rankScreen.SetActive(false);
    }
}

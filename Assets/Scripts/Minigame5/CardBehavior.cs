using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CardBehavior : MonoBehaviour, IDragHandler, IEndDragHandler
{

    RectTransform rectTransform;
    RectTransform StartPos;


    // Start is called before the first frame update
    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        StartPos = GameObject.Find("CardStartPos").GetComponent<RectTransform>();
    }

    // Update is called once per frame
    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta;
    }
    public void OnEndDrag(PointerEventData eventData) 
    {
        rectTransform.anchoredPosition = StartPos.anchoredPosition;
    }
}

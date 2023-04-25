using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LeverScript : MonoBehaviour, IPointerDownHandler
{

    public Sprite LeverUp;
    public Sprite LeverDown;
    public bool LeverPulled = false;
    public Image CurrentImg;


    public void OnPointerDown(PointerEventData eventData)
    {
        if (LeverPulled == false)
        {
            Debug.Log("ÖnPointerDown");
            LeverPulled = true;
            CurrentImg.sprite = LeverDown;
        }
        else
        {
            LeverPulled = false;
            CurrentImg.sprite = LeverUp;
        }

    }
}

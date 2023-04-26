using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LeverScript : MonoBehaviour
{

    public Sprite LeverDown;
    public bool LeverPulled = false;
    public Image CurrentImg;

    private void Start()
    {
        CurrentImg = gameObject.GetComponentInChildren<Image>();
    }

    public void OnClick()
    {
        LeverPulled = true;
        CurrentImg.sprite = LeverDown;

    }
}

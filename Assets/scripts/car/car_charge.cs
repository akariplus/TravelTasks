using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class car_charge : MonoBehaviour
{
    public Slider slider;
    public float charge = 0f;
    public bool done = false;
    void Update()
    {
        if (charge < 1)
        {
            slider.value = charge;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                charge += 0.025f;
            }
        }
        if (charge > 1)
        {
            done = true;
        }
    }
}

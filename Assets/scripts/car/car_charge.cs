using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class car_charge : MonoBehaviour
{
    public Slider slider;
    public float charge = 0f;
    public bool done = false;
    SceneHandler sceneHandler;
    GameObject timer;

    private void Start()
    {
        sceneHandler = GetComponent<SceneHandler>();
        timer = GameObject.Find("TimerCanvas");
    }

    void Update()
    {
        if (charge < 1)
        {
            slider.value = charge;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                charge += 0.1f;
            }
        }
        if (charge > 1 && !done)
        {
            done = true;
            timer.SetActive(false);
            StartCoroutine(sceneHandler.FinishedMinigame());
        }
    }
}

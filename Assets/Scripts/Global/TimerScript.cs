using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    SceneHandler sceneHandler;
    Slider timer;
    AudioSource source;
    bool PlayedWarning;


    // Start is called before the first frame update
    void Start()
    {
        sceneHandler= GetComponent<SceneHandler>();
        timer = GetComponent<Slider>();
        source = GetComponent<AudioSource>();
        timer.maxValue = GlobalData.TimerTime;
    }

    // Update is called once per frame
    void Update()
    {
        timer.value += Time.deltaTime;
        if (timer.value >= timer.maxValue-3 && !PlayedWarning)
        {
            source.Play();
            PlayedWarning = true;
        }
        else if(timer.value >= timer.maxValue )
        {
            Debug.Log("You Failed");
            GlobalData.Lives--;
            sceneHandler.LoadScene("FailMinigame");
        }
    }
}

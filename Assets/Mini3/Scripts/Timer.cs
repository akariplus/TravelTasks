using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public SceneManager SceneManager;
    public bool timerOn = false;
    public float timeLeft;
    
    public RectTransform Player;
    public RectTransform end;
    
    public TextMeshProUGUI TimerText;

    void Start()
    {
        timerOn = true;
    }

    void Update()
    {
        if (timerOn)
        {
            if (timeLeft > 0)
            {
                timeLeft -= Time.deltaTime;
                updateTimer(timeLeft);
            }
            else
            {
                Debug.Log("Time has ended");
                timeLeft = 0;
                timerOn = false;
            }
        }

        if(Player.position.x > end.position.x)
        {
            Debug.Log("HELP");
            timerOn= false;

        }
    }

    private void updateTimer(float currentTime)
    {
        currentTime += 1;

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        TimerText.text = string.Format("{1:00}", minutes, seconds);
    } 
}
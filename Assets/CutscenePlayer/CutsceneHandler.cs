using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneHandler : MonoBehaviour
{

    public GameObject GameWindow, CutsceneWindow, Timer;
    public Animator anim;
    public SceneHandler sceneHandler;

    private void Start()
    {
        GameWindow = GameObject.Find("Game");
        CutsceneWindow = GameObject.Find("CutsceneWindow");
        Timer = GameObject.Find("TimerCanvas");
        anim = GameObject.Find("Cutscene").GetComponent<Animator>();
        sceneHandler = gameObject.GetComponent<SceneHandler>();
        CutsceneWindow.SetActive(false);
    }


    public void PlayEndCutscene(int Minigame)
    {
        GameWindow.SetActive(false);
        CutsceneWindow.SetActive(true);
        Timer.SetActive(false);
        anim.SetTrigger("PlayWinCutscene" + Minigame);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneHandler : MonoBehaviour
{

    public GameObject GameWindow, CutsceneWindow;
    public Animator anim;
    public SceneHandler sceneHandler;

    private void Start()
    {
        GameWindow = GameObject.Find("Game");
        CutsceneWindow = GameObject.Find("CutsceneWindow");
        anim = GameObject.Find("Cutscene").GetComponent<Animator>();
        sceneHandler = gameObject.GetComponent<SceneHandler>();
        CutsceneWindow.SetActive(false);
    }


    public void PlayEndCutscene()
    {
        GameWindow.SetActive(false);
        CutsceneWindow.SetActive(true);
        anim.SetTrigger("PlayWinCutscene");
    }

}

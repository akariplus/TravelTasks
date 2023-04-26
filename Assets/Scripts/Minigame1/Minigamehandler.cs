using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Minigamehandler : MonoBehaviour
{
    public int ToBePacked = 4;
    public int Packed = 0;
    public bool Finished, PlayedCutscene = false;
    private BackpackScript backpackScript;
    private CutsceneHandler cutsceneHandler;


    private void Start()
    {
        backpackScript = GameObject.Find("Backpack").GetComponent<BackpackScript>();
        cutsceneHandler = GameObject.Find("Canvas").GetComponent<CutsceneHandler>();
    }


    // Update is called once per frame
    void Update()
    {
        if (!Finished && !PlayedCutscene)
        {
            if (Packed == ToBePacked)
            {
                Finished = true;
                backpackScript.Finish();
                cutsceneHandler.PlayEndCutscene(1);
                PlayedCutscene = true;
            }
        }
    }

}

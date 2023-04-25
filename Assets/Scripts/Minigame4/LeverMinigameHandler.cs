using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverMinigameHandler : MonoBehaviour
{

    LeverScript Lever;
    bool Finished;
    private bool LoadingNew;
    SceneHandler sceneHandler;

    // Start is called before the first frame update
    void Start()
    {
        Lever = GameObject.Find("LeverPlaceholder").GetComponent<LeverScript>();
        sceneHandler = GetComponent<SceneHandler>();

    }

    // Update is called once per frame
    void Update()
    {
        if (!Finished)
        {
            if (Lever.LeverPulled)
            {
                Finished = true;
            }
        }
        else if (!LoadingNew)
        {
            LoadingNew = true;
            StartCoroutine(sceneHandler.FinishedMinigame());
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingMinigameHandler : MonoBehaviour
{

    RectTransform Player, EndTrigger;
    SceneHandler sceneHandler;
    bool Finished;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player").GetComponent<RectTransform>();
        EndTrigger = GameObject.Find("EndTrigger").GetComponent<RectTransform>();
        sceneHandler = GetComponent<SceneHandler>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.anchoredPosition.x >= EndTrigger.anchoredPosition.x && !Finished)
        {
            Finished = true;
            sceneHandler.FinishedMinigame();
        }
    }
}

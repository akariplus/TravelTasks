using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Minigamehandler : MonoBehaviour
{

    public int ToBePacked = 4;
    public int Packed = 0;
    private TMP_Text textField;
    public bool Finished = false;
    private SceneHandler sceneHandler;
    private bool LoadingNew;


    private void Start()
    {
        textField = GameObject.Find("GameHeader").GetComponent<TMP_Text>();
        sceneHandler = GetComponent<SceneHandler>();
    }


    // Update is called once per frame
    void Update()
    {
        if (!Finished)
        {
            if (Packed == ToBePacked && !Finished)
            {
                Finished = true;
            }
        }
        else if (!LoadingNew)
        {
            LoadingNew = true;
            StartCoroutine(sceneHandler.FinishedMinigame());
        }
        else
        {

        }
    }
}

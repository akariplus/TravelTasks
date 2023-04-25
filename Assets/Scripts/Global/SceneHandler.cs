using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{

    string[] Scenes = new string[] { "MainMenu", "Mini1", "Mini2", "Mini3", "Mini4", "Mini5", "Mini6", "WinScreen", "GameOverScreen" };


    public void LoadRandomScene()
    {
        int i = Random.Range(1, Scenes.Length-2);
        while (Scenes[i] == GlobalData.LastMinigame)
        {
            i = Random.Range(1, Scenes.Length-2);
        }
        SceneManager.LoadScene(Scenes[i]);

    }
}

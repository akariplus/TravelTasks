using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{

    string[] Minigames = new string[] { "Mini1", "Mini2", "Mini3", "Mini4", "Mini5", "Mini6" };
    string[] Menus = new string[] { "MainMenu", "WinScreen", "GameOverScreen" };


    public void LoadRandomScene()
    {
        int i = Random.Range(0, Minigames.Length);
        while (Minigames[i] == GlobalData.LastMinigame)
        {
            i = Random.Range(0, Minigames.Length);
        }
        GlobalData.LastMinigame = Minigames[i];
        SceneManager.LoadScene(Minigames[i]);
    }

    public IEnumerator FinishedMinigame()
    {
        Debug.Log("FinishedMinigame");
        GlobalData.CompletedMinigames++;
        yield return new WaitForSeconds(2);
        LoadRandomScene();
    }

    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }
}

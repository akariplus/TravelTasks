using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartScript : MonoBehaviour
{

    GameObject Panel2L, Panel1L;
    SceneHandler sceneHandler;
    bool LoadingNew;

    // Start is called before the first frame update
    void Start()
    {
        Panel2L = GameObject.Find("HeartPanel 2L");
        Panel1L = GameObject.Find("HeartPanel 1L");
        Panel2L.SetActive(false);
        Panel1L.SetActive(false);
        sceneHandler = GetComponent<SceneHandler>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GlobalData.Lives == 2)
        {
            Panel2L.SetActive(true);
        }
        else if (GlobalData.Lives == 1)
        {
            Panel2L.SetActive(true);
        }
        else if (GlobalData.Lives == 0)
        {
            sceneHandler.LoadScene("GameOverScreen");
        }
    }

}

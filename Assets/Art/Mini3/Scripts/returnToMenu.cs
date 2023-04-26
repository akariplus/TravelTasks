using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class returnToMenu : MonoBehaviour
{

    private void Start()
    {
        
    }

    private void Update()
    {
        
    }


    public void ReturnToMenu()
    {
        SceneManager.LoadScene(0);
    }
}

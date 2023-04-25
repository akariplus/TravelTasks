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


    private void Start()
    {
        textField = GameObject.Find("GameHeader").GetComponent<TMP_Text>();
    }


    // Update is called once per frame
    void Update()
    {
        if (Packed == ToBePacked && !Finished)
        {
            Debug.Log("Finished");
            Finished = true;
            textField.text = "Finished!";
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScannerMinigameHandler : MonoBehaviour
{

    Transform Scanner;
    GameObject ScannerSlider;
    Transform Card;
    public float Progress = 0;
    bool Finished = false;

    // Start is called before the first frame update
    void Start()
    {
        Scanner = GameObject.Find("Scanner").GetComponent<Transform>();
        ScannerSlider = GameObject.Find("ScannerSlider");
        Card = GameObject.Find("Card").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!Finished)
        {
            Vector2 direction = Card.position - Scanner.position; // distance from scanner to card

            if ((direction.x < 125 && direction.x > -125) && (direction.y < 125 && direction.y > -125)) // if the card is close enough to the scanner
            {
                Progress += Time.deltaTime;
                ScannerSlider.SetActive(true); // progression bar is appears
            }
            else // when card is no longer close enough
            {
                Progress = 0; // reset progress
                ScannerSlider.SetActive(false); // progression bar disappears
            }

            if (Progress > 2)
            {
                Debug.Log("Finished");
                Finished = true;
            }
        }
        else
        {

        }
    }
}

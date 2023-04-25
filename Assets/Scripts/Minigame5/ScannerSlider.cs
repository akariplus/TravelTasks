using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScannerSlider : MonoBehaviour
{

    public Slider slider;
    public ScannerMinigameHandler Handler;

    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
        Handler = GameObject.Find("Game").GetComponent<ScannerMinigameHandler>();
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = Handler.Progress;
    }
}

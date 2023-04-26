using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.UI;

public class pump : MonoBehaviour
{
    public Slider air_slider;
    public Slider timer_slider;
    public Transform Pump;
    public Animator animator;
    public Transform player;
    public float air = 0f;
    public Vector2 mouse_y;
    public float previous_y;
    public float y_change;
    public float timer = 0f;
    public bool done = false;
    public bool is_done = false;
    private void Start()
    {

    }

    void FixedUpdate()
    {
        if (!done)
        {
            //set timer
            timer += 1 * Time.deltaTime;

            //move pump shape
            Pump.position = new Vector3(6, Input.mousePosition.y / 200 - 3, 0);

            //set previous y
            y_change = Input.GetAxis("Mouse Y") - previous_y;

            //Check if y movement down
            if (y_change < 0f)
            {
                y_change = 0f;
            }

            //add mouse movement to air
            air += y_change / 10f;

            //reduse air
            if (air > 0)
            {
                air -= 0.025f;
            }

            //check if done
            if (air > 10)
            {
                done = true;
            }

            //set slider
            air_slider.value = air;
            timer_slider.value = timer;

            //set previous
            previous_y = Input.GetAxis("Mouse Y");
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceBarMovement : MonoBehaviour
{
    float speed = 30f;

    public Animator ani;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position += transform.right * Time.deltaTime * speed;
            ani.ResetTrigger("isIdle");
            ani.SetTrigger("isRunning");
                    
        }
    }
}

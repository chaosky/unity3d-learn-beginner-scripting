using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonInput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("standard");
    }

    // Update is called once per frame
    void Update()
    {
        bool down = Input.GetButtonDown("Jump");
        bool held = Input.GetButton("Jump");
        bool up = Input.GetButtonUp("Jump");

        if (down)
        {
            Debug.Log("down");
        }
        else if (held)
        {
            Debug.Log("held");
        }
        else if (up)
        {
            Debug.Log("up");
        }
        // else
        // {
        //     Debug.Log("standard");
        // }
    }
}

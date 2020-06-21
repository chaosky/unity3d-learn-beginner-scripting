using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("standard");
    }

    // Update is called once per frame
    void Update()
    {
        bool down = Input.GetKeyDown(KeyCode.Space);
        bool held = Input.GetKey(KeyCode.Space);
        bool up = Input.GetKeyUp(KeyCode.Space);

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

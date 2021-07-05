using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMenu : MonoBehaviour
{
    private bool isPressed = false;
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isPressed)
        {
            ShowGUI();
            isPressed = false;
        }
        // if (Input.touchCount > 0) {
        //     ShowGUI();
        // }
    }

    void ShowGUI()
    {
        Debug.Log("Screen Touched");
    }
}

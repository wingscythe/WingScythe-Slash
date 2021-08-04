using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour {

    [SerializeField]
    private bool paused = false;

    public void pauseGame() {
        Time.timeScale = 0;
        // Debug.Log("Button Pressed");
        // if (!paused) {
        //     Debug.Log("Paused!");
        //     Time.timeScale = 0;
        //     paused = true;
        // } else {
        //     Debug.Log("Resumed!");
        //     Time.timeScale = 1;
        //     paused = false;
        // }
    }
    public void unPause() {
        Time.timeScale = 1;
    }

}
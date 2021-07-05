using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuOpener : MonoBehaviour
{
    public GameObject startButton;
    public GameObject startFadeText;

    public void OpenMenu()
    {
        startFadeText.SetActive(false);
        startButton.SetActive(true);
    }
}

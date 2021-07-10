using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuOpener : MonoBehaviour
{
    public List<GameObject> UIElements = new List<GameObject>();
    public GameObject startFadeText;

    public void OpenMenu()
    {
        startFadeText.SetActive(false);
        foreach (GameObject item in UIElements)
        {
            item.SetActive(true);
        }
    }
}

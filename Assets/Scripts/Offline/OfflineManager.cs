using System;
using UnityEngine;

public class OfflineManager : MonoBehaviour
{
    private DateTime lastLoginTime;
    // Start is called before the first frame update
    void Start()
    {
        var totalTime = DateTime.Now - lastLoginTime;
    }

    private void OnApplicationQuit()
    {
        lastLoginTime = DateTime.Now;
    }
}

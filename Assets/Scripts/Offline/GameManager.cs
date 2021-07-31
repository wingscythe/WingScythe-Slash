using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public int level = 0;

    void Start() {
        GameData data = Save.LoadGameData();
        if (data != null) {
            level = data.level;
            TimeSpan TimeGone = DateTime.Now - DateTime.Parse(data.lastLogin);
            Debug.Log("Currrent Time: " + DateTime.Now.ToString());
            Debug.Log("Last Login Time: " + data.lastLogin);
            Debug.Log("Seconds passed: " + TimeGone.TotalSeconds);
        }
    }
    private void OnApplicationQuit() {
        DateTime lastLoginTime = DateTime.Now;
        Save.SaveGameData(this, lastLoginTime);
    }
}

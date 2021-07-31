using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

[System.Serializable]
public class GameData {
    public int level;
    public string lastLogin;

    public GameData(GameManager manager, DateTime lastLoginTime) {
        level = manager.level;
        lastLogin = lastLoginTime.ToString();
    }
}

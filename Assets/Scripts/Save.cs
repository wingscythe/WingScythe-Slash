using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

/*
 * This class manually saves any item by keypress.
 * 
 * Author: Ryan Xu
 * 
 * Note:
 * Things to do after saving:
 * */
public class Save : MonoBehaviour {

    public static Save Instance { get; set; }

    [Header("General")]
    private BinaryFormatter bf = new BinaryFormatter();

    void Awake() {
        if (Instance) {
            Destroy(this.gameObject);
        }
        Instance = this;
        Debug.Log("Save Database Initialized!");
        DontDestroyOnLoad(this.gameObject);
    }

    private void OnApplicationQuit() {
        //Save State
        SaveGame();
    }

    void SaveGame() {
        setStats(PlayerController.Instance.playerStats);
        setGold(PlayerController.Instance.playerGold);
        // Ryan Note: save state for waves / levels once integrated.
    }

    public Stat getStats(string name) {
        //Player Stats
        if (File.Exists("./Assets/Resources/Saves/pstats" + name + ".wingscythe")) {
            FileStream stream = new FileStream("./Assets/Resources/Saves/pstats" + name + ".wingscythe", FileMode.Open);
            Stat stats = bf.Deserialize(stream) as Stat;
            stream.Close();
            return stats;
        }
        return null;
    }

    void setStats(PlayerStat stats) {
        setStat(stats.Strength, "Strength");
        setStat(stats.Speed, "Speed");
        setStat(stats.AtkSpeed, "AtkSpeed");
        setStat(stats.Health, "Health");
        setStat(stats.MaxHealth, "MaxHealth");
    }

    void setStat(Stat stat, string name) {
        FileStream stream = new FileStream("./Assets/Resources/Saves/pstats" + name + ".wingscythe", FileMode.Create);
        bf.Serialize(stream, stat);
        stream.Close();
    }

    void setGold(PlayerGold playerGold) {
        setStat(playerGold.gold, "Gold");
    }
}
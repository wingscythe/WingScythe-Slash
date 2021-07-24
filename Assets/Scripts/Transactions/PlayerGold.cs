using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGold : MonoBehaviour {
    public static PlayerGold Instance;

    [SerializeField]
    private int value = 0;
    public Stat gold;

    private void Awake() {
        Instance = this;
    }

    void Start() {
        gold.SetValue(0);
        //Get saved PlayerStat if relevant
        Stat save = Save.Instance.getStats("Gold");
        if (save != null) {
            value = save.getValue();
            gold.SetValue(value);
        }
    }

    public void addGold(Gold coin) {
        value += coin.getValue();
        gold.SetValue(value);
    }

    public void minusGold(Gold coin) {
        value -= coin.getValue();
        gold.SetValue(value);
    }

    public int showGold() {
        return value;
    }
}

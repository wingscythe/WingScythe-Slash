using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerGoldDisplay : MonoBehaviour {
    private PlayerGold gold;
    private Text goldDisplay;
    private void Awake() {
        gold = GameObject.FindWithTag("Player").GetComponent<PlayerGold>();
        goldDisplay = gameObject.GetComponent<Text>();
    }

    void Update() {
        goldDisplay.text = "" + gold.showGold();
    }
}

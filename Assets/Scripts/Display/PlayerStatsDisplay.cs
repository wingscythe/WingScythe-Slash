using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStatsDisplay : MonoBehaviour {
    [SerializeField] Text Health, Strength, AtkSpeed; //Speed ;
    public PlayerStat stats;
    private Text statsDisplay;
    private void Awake() {
        statsDisplay = gameObject.GetComponent<Text>();
    }
    //Updating Text
    void Update() {
        Strength.text = "Strength: " + stats.getStrength().ToString();
        //Speed.text = "Speed: " + stats.getSpeed().ToString();
        AtkSpeed.text = "Attack Speed: " + stats.getAtkSpeed().ToString();
        Health.text = "Health: " + stats.getHealth().ToString() + "/" + stats.MaxHealth.getValue().ToString();
    }
}

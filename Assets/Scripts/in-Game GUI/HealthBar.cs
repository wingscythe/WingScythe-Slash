using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {
    public Image healthBarImage;
    public PlayerStat stats;

    // Update is called once per frame
    void Update() {
        healthBarImage.fillAmount = (1.0f * stats.getHealth()) / stats.MaxHealth.getValue();
    }
}

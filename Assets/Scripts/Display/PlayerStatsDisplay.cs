using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStatsDisplay : MonoBehaviour
{
    [SerializeField] Text Strength, Speed, AtkSpeed;
    private PlayerStat stats;
    private Text statsDisplay;
    private void Awake()
    {
        stats = GameObject.FindWithTag("Player").GetComponent<PlayerStat>();
        statsDisplay = gameObject.GetComponent<Text>();
    }

    void Update()
    {
        Strength.text = "Strength: " + stats.getStrength().ToString();
        Speed.text = "Speed: " + stats.getSpeed().ToString();
        AtkSpeed.text = "Attack Speed: " + stats.getAtkSpeed().ToString();
    }
}

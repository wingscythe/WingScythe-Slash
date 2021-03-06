using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeHealth : ShopManager {
    [SerializeField]
    private PlayerGold player;
    [SerializeField]
    private PlayerStat stat;
    public GameObject stick;
    private int cost = 100;
    public UpgradeHealth() {
        this.upgrades = 0;
        this.max = 1;
    }

    public void HealthUp() {
        if (player.showGold() < cost) {
            if (maxUpgrades(max)) return;
            this.GetComponentInChildren<Text>().text = "NOT ENOUGH GOLD";
            return;
        } else {
            stat.setHealth(stat.Health.getValue() + 50);
            player.minusGold(new Gold(cost));
            increaseCost();
            if (maxUpgrades(max)) {
                this.GetComponentInChildren<Text>().text = "MAX UPGRADES";
            }
        }
    }

    public void increaseCost() {
        cost += 100;
        upgrades++;
    }
}
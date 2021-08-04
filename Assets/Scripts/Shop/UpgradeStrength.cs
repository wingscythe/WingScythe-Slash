using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeStrength : ShopManager {
    [SerializeField]
    private PlayerGold player;
    [SerializeField]
    private PlayerStat stat;
    public GameObject stick;
    private int cost = 100;
    public UpgradeStrength() {
        this.upgrades = 0;
        this.max = 1;
    }
    public void StrengthUp() {
        if (player.showGold() < cost) {
            if (maxUpgrades(max)) {
                this.GetComponent<Button>().interactable = false;
                return;
            }
            this.GetComponentInChildren<Text>().text = "NOT ENOUGH GOLD";
            return;
        } else {
            stat.setStrength(stat.Strength.getValue() + 50);
            Debug.Log("SET STRENGTH :" + stat.getStrength());
            player.minusGold(new Gold(cost));
            increaseCost();
            if (maxUpgrades(max)) {
                this.GetComponentInChildren<Text>().text = "MAX UPGRADES";
                this.GetComponent<Button>().interactable = false;
            }
        }
    }
    public void increaseCost() {
        cost += 200;
        upgrades++;
    }
}
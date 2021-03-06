using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour {
    protected int max;
    protected int upgrades;
    public GameObject Panel;

    public bool maxUpgrades(int max) {
        if (upgrades == max) return true;
        else return false;
    }

    public void openShop() {

        if (Panel != null) {
            bool open = Panel.activeSelf;
            Panel.SetActive(!open);
            if (this.GetComponentInChildren<Text>().tag == "Gold" && open) {
                Debug.Log("FOUND");
                this.GetComponentInChildren<Text>().color = Color.black;
            } else {
                this.GetComponentInChildren<Text>().color = Color.white;
            }
            //if (Panel.GetComponentInChildren<Text>().tag == "Gold" && !open) gameObject.GetComponent<Text>().color = Color.black;
        }
    }

}
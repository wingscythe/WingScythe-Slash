using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public float currentHealth;
    public float maximumHealth = 100f;
    Image healthBarImage;
    Player_Stats player;
    // Start is called before the first frame update
    void Start()
    {
        // GameObject hi = gameObject.GetChild(1).gameObject;
        // // console.log(hi.transform.position.)
        healthBarImage = gameObject.transform.GetChild(1).gameObject.GetComponent<Image>();
        // Debug.Log(gameObject.transform.GetChild(1).gameObject.GetComponent<Image);
        player = FindObjectOfType<Player_Stats>();
    }

    // Update is called once per frame
    void Update()
    {
        currentHealth = player.health;
        healthBarImage.fillAmount = currentHealth / maximumHealth;  
    }
}

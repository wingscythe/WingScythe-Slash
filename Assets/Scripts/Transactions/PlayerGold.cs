using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGold : MonoBehaviour
{
    [SerializeField]
    private int value = 0;

    public void addGold(Gold coin)
    {
        value += coin.getValue();
    }

    public int showGold()
    {
        return value;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.G)){
            Gold g = new Gold();
            g.setValue(10);
            addGold(g);
        }
    }
}

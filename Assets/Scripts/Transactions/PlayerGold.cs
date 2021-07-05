using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGold : MonoBehaviour
{
    public static PlayerGold Instance;

    [SerializeField]
    private int value = 0;

    private void Awake()
    {
        Instance = this;
    }

    public void addGold(Gold coin)
    {
        value += coin.getValue();
    }

    public void minusGold(Gold coin)
    {
        value -= coin.getValue();
    }

    public int showGold()
    {
        return value;
    }
}

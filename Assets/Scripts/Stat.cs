using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Stat
{
    [SerializeField]
    private int baseValue;

    public int getValue()
    {
        return this.baseValue;
    }

    public int SetValue(int n) { 
        this.baseValue = n;
        return this.baseValue;
    }
}
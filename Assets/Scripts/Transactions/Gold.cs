using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold
{
    [SerializeField]
    private int value;

    public void setValue(int value) 
    {
        this.value = value;
    }

    public int getValue()
    {
        return this.value;
    }
}

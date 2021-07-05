using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    private int cost;

    public virtual void increaseCost(int gold)
    {
        cost += gold;
    }
}
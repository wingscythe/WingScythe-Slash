using UnityEngine;

[System.Serializable]
public class Wave
{
    public string name { get; set; }
    public Transform enemy { get; set; }
    public int count { get; set; }
    public float rate;
}

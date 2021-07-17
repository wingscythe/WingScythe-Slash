using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour {
    public enum SpawnState { SPAWNING, WAITING, COUNTING };

    public Wave[] waves;
    private int nextWave = 0;

    public float timeBetweenWaves = 5f;

    public float waveCountdown;

    private SpawnState state = SpawnState.COUNTING;

    // Start is called before the first frame update
    void Start() {
        waveCountdown = timeBetweenWaves;
    }

    // Update is called once per frame
    void Update() {
        if (waveCountdown <= 0) {
            if (state != SpawnState.SPAWNING) {
                //Spawn wave
            }
        } else {
            waveCountdown -= Time.deltaTime;
        }
    }
}

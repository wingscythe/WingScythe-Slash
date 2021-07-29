﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour {
    public enum SpawnState { SPAWNING, WAITING, COUNTING };
    public Wave[] waves;
    private int nextWave = 0;
    public Transform[] spawnPoints;
    public float timeBetweenWaves = 5f;
    public float waveCountdown;
    private SpawnState state = SpawnState.COUNTING;
    private float searchCountdown = 1f;

    // Start is called before the first frame update
    void Start() {
        waveCountdown = timeBetweenWaves;
    }

    // Update is called once per frame
    void Update() {
        if (state == SpawnState.WAITING) {
            //Check if enemies are still alive
            if (EnemyIsAlive()) {
                return;
            }
            WaveCompleted();
        }

        if (waveCountdown <= 0) {
            if (state != SpawnState.SPAWNING) {
                StartCoroutine(SpawnWave(waves[nextWave]));
            }
        } else {
            waveCountdown -= Time.deltaTime;
        }
    }

    void WaveCompleted() {
        Debug.Log("Wave Completed");
        state = SpawnState.COUNTING;
        waveCountdown = timeBetweenWaves;
        if (nextWave + 1 > waves.Length - 1) {
            nextWave = 0;
            Debug.Log("Completed All Waves");
        } else {
            nextWave++;
        }
    }

    bool EnemyIsAlive() {
        searchCountdown -= Time.deltaTime;
        if (searchCountdown <= 0f) {
            if (!GameObject.FindGameObjectWithTag("Enemy")) {
                return false;
            }
        }
        return true;
    }

    IEnumerator SpawnWave(Wave _wave) {
        state = SpawnState.SPAWNING;

        for (int i = 0; i < _wave.count; i++) {
            SpawnEnemy(_wave.enemy);
            yield return new WaitForSeconds(1f / _wave.rate);
        }

        state = SpawnState.WAITING;

        yield break;
    }

    void SpawnEnemy(Transform _enemy) {
        Debug.Log("Spawning " + _enemy.name);
        Transform _sp = spawnPoints[Random.Range(0, spawnPoints.Length)];
        Instantiate(_enemy, _sp.position, _sp.rotation);
    }
}

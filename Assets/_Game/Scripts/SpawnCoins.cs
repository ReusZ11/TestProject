
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Random = UnityEngine.Random;

public class SpawnCoins : MonoBehaviour
{
    public Transform[] spawnPositions;
    public GameObject coin;
    private Transform previousCoinSpawnPoint;

    private void Awake()
    {
        Spawn();
        EventManager.OnSpawn.AddListener(Spawn);
    }


    public void Spawn()
    {
        Transform spawnPoint;
        do
        {
            int randomIndexPosition = Random.Range(0, spawnPositions.Length);
            spawnPoint = spawnPositions[randomIndexPosition];
        } while (spawnPoint == previousCoinSpawnPoint);


        GameObject.Instantiate(coin, spawnPoint.position, spawnPoint.rotation);
        previousCoinSpawnPoint = spawnPoint;
    }




    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Spawn();
        }
    }



}

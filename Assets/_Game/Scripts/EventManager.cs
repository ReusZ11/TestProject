using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventManager
{
    public static UnityEvent OnSpawn = new UnityEvent();
    public static UnityEvent OnDestroyCoin = new UnityEvent();
    public static UnityEvent OnAddScore = new UnityEvent();
    public static UnityEvent OnAddTime = new UnityEvent();


    public static void DestroyCoinEvent()
    {
        OnDestroyCoin.Invoke();
        SpawnCoinEvent();
    }

    public static void SpawnCoinEvent()
    {
        OnSpawn.Invoke();
    }

    public static void AddScoreEvent()
    {
        OnAddScore.Invoke();
    }

    public static void AddTimeEvent()
    {
        OnAddTime.Invoke();
    }

}

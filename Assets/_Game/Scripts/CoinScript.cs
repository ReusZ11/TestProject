using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    [SerializeField] private GameObject particlePrefab;
    void Start()
    {
        EventManager.OnDestroyCoin.AddListener(DestroyCoin);

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            EventManager.DestroyCoinEvent();
        }
    }

    public void DestroyCoin()
    {
        EventManager.AddTimeEvent();
        EventManager.AddScoreEvent();
        Debug.Log("Killed");
        CreateParticle();
        Destroy(gameObject);
    }

    private void CreateParticle()
    {
        GameObject.Instantiate(particlePrefab, gameObject.transform.position, gameObject.transform.rotation);
    }
}

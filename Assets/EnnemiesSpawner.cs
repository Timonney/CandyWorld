using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemiesSpawner : MonoBehaviour
{
    public float maxTime, minTime;
    public GameObject ennemyPref;

    public Transform[] positions;


    private void Start()
    {
        Invoke("SpawnEnnemi", GetRandomTime());
    }

    private void SpawnEnnemi()
    {
        Vector3 position = positions[GetRandomLine()].position;

        GameObject o = Instantiate(ennemyPref, position, Quaternion.identity);

        Invoke("SpawnEnnemi", GetRandomTime());
    }

    private float GetRandomTime()
    {
        return Random.Range(minTime, maxTime);
    }

    private int GetRandomLine()
    {
        return Random.Range(0, positions.Length);
    }
}

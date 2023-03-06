using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class sauce : MonoBehaviour
{
    public GameObject cyanPrefab;
    public GameObject pinkPrefab;
    public GameObject yellowPrefab;

    private GameObject lastCyan;
    private float lastCyanY = -1000f;
    private int cyanCount = 0;

    private GameObject lastPink;
    private float lastPinkY = -1000f;

    private GameObject lastYellow;
    private float lastYellowY = -1000f;

    void Start()
    {
        SpawnCyan();
        SpawnPink();
        SpawnYellow();
    }

    void Update()
    {
        if (lastCyan.transform.position.y < lastCyanY + 200f && cyanCount < 4)
        {
            SpawnCyan();
        }

        if (lastPink.transform.position.y < lastPinkY + 500f)
        {
            SpawnPink();
        }

        if (lastYellow.transform.position.y < lastYellowY + 1000f)
        {
            SpawnYellow();
        }
    }

    void SpawnCyan()
    {
        Vector2 spawnPosition = new Vector2(UnityEngine.Random.Range(-2.5f, 2.5f), lastCyanY + 200f);
        lastCyan = Instantiate(cyanPrefab, spawnPosition, Quaternion.identity);
        lastCyanY = lastCyan.transform.position.y;
        cyanCount++;
    }

    void SpawnPink()
    {
        Vector2 spawnPosition = new Vector2(UnityEngine.Random.Range(-2.5f, 2.5f), lastPinkY + 500f);
        lastPink = Instantiate(pinkPrefab, spawnPosition, Quaternion.identity);
        lastPinkY = lastPink.transform.position.y;
    }

    void SpawnYellow()
    {
        Vector2 spawnPosition = new Vector2(UnityEngine.Random.Range(-2.5f, 2.5f), lastYellowY + 1000f);
        lastYellow = Instantiate(yellowPrefab, spawnPosition, Quaternion.identity);
        lastYellowY = lastYellow.transform.position.y;
    }
}

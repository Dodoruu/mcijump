using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyer : MonoBehaviour
{
    public GameObject player;
    public GameObject platformPrefab;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        float minX = -2.2f;
        float maxX = 2.2f;

        Vector2 spawnPosition = new Vector2(UnityEngine.Random.Range(minX, maxX), player.transform.position.y + (4 + UnityEngine.Random.Range(0.5f, 1.5f)));

        GameObject newPlatform = Instantiate(platformPrefab, spawnPosition, Quaternion.identity);

        Destroy(collision.gameObject);
    }
}

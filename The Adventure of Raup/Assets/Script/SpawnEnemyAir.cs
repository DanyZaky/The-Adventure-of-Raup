﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemyAir : MonoBehaviour
{
    public bool gameOverr = false;
    public GameObject enemyAir;
    void Start()
    {
        StartCoroutine(duplicate());
    }

    IEnumerator duplicate()
    {
        while (!gameOverr)
        {
            float jarakObj = Random.Range(4.0f, 6.0f);
            yield return new WaitForSeconds(jarakObj);

            if (!gameOverr)
            {
                GameObject obstacle = Instantiate(enemyAir, transform.position, transform.rotation, transform);
                obstacle.name = "CloneEnemyAir";
            }
        }
    }
}

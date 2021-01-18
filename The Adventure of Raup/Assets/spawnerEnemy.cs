using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerEnemy : MonoBehaviour
{
    public GameObject enemyGround;

    float time = 0;
    float timer = 1;

    void Update()
    {
        if (time <= 0)
        {
            Instantiate(enemyGround, transform.position, Quaternion.identity);
            time = timer;
        }
        else
        {
            time -= Time.deltaTime;
        }
    }
}

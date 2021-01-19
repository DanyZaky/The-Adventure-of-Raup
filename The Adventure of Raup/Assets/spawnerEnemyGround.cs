using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerEnemyGround : MonoBehaviour
{
    public bool gameOver = false;
    public GameObject enemyGround;
    void Start()
    {
        StartCoroutine(duplicate());
    }

    void Update()
    {

    }

    IEnumerator duplicate()
    {
        while (!gameOver)
        {
            float jarakObj = Random.Range(2, 4);
            yield return new WaitForSeconds(jarakObj);

            if (!gameOver)
            {
                GameObject obstacle = Instantiate(enemyGround, transform.position, transform.rotation, transform);
                obstacle.name = "CloneEnemyGround";
            }
        }
    }
}

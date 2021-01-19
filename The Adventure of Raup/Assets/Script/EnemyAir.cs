using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAir : MonoBehaviour
{
    public float moveAir; 

    void Update()
    {
        transform.Translate(moveAir, 0, 0);

        if (transform.position.x < -15)
        {
            Destroy(gameObject);
        }
    }
}

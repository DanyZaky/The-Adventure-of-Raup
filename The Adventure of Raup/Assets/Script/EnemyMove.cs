using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float moveSpeed;

    void Update()
    {
        transform.Translate(moveSpeed, 0, 0);
        
        if (transform.position.x < -15)
        {
            Destroy(gameObject);
        }
    }
}

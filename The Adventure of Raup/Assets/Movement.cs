using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    public GameObject gameOver, restartButton, score, terrain, enemySpawn;
    
    Rigidbody2D rb;
    Animator anim;

    public int jump;
    public bool jumping;
    float scoreValue;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.UpArrow) && jumping == true)
        {
            rb.velocity = new Vector2(0,jump);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            anim.SetBool("isNunduk", true);
        }
        else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            anim.SetBool("isNunduk", false);
        }
        
        if (transform.position.y < 0)
        {
            anim.SetBool("isJumping", false);
            jumping = true;
        }
        else if (transform.position.y > 0)
        {
            anim.SetBool("isJumping", true);
            jumping = false;
        }

        if (!gameOver.activeSelf)
        {
            scoreValue = scoreValue + 0.5f;
            score.GetComponent<Text>().text = "" + scoreValue.ToString();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemyGround")
        {
            anim.SetBool("isDeath", true);
            terrain.GetComponent<Animator>().enabled = false;
            enemySpawn.GetComponent<spawnerEnemyGround>().gameOver = true;

            gameOver.SetActive(true);
            restartButton.SetActive(true);

            for (int i = 0; i < enemySpawn.transform.childCount; i++)
            {
                enemySpawn.transform.GetChild(i).GetComponent<EnemyMove>().moveSpeed = 0;
            }
        }
    }

}

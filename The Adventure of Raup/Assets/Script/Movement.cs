using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    public GameObject gameOverText, restartButton, mainMenuButton, score, terrain, enemyGroundSpawn, enemyAirSpawn;
    
    Rigidbody2D rb;
    Animator anim;

    public int jump;
    public bool jumping;
    int scoreValue;

    public bool buttonJump;
    public bool buttonNunduk;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {

        if ((Input.GetKeyDown(KeyCode.UpArrow) || buttonJump == true) && jumping == true)
        {
            rb.velocity = new Vector2(0,jump);
            soundManager.PlaySound("jump");
            buttonJump = false;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow) || buttonNunduk == true)
        {
            anim.SetBool("isNunduk", true);
        }
        else if (Input.GetKeyUp(KeyCode.DownArrow) || buttonNunduk == false)
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
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemyGround")
        {
            anim.SetBool("isDeath", true);
            terrain.GetComponent<Animator>().enabled = false;
            enemyGroundSpawn.GetComponent<spawnerEnemyGround>().gameOver = true;
            enemyAirSpawn.GetComponent<SpawnEnemyAir>().gameOverr = true;

            gameOverText.SetActive(true);
            restartButton.SetActive(true);
            mainMenuButton.SetActive(true);

            for (int i = 0; i < enemyGroundSpawn.transform.childCount; i++)
            {
                enemyGroundSpawn.transform.GetChild(i).GetComponent<EnemyMove>().moveSpeed = 0;
            }

            for (int i = 0; i < enemyAirSpawn.transform.childCount; i++)
            {
                enemyAirSpawn.transform.GetChild(i).GetComponent<EnemyAir>().moveAir = 0;
            }

            if (PlayerPrefs.GetInt("highscore") < scoreValue)
            {
                PlayerPrefs.SetInt("highscore", scoreValue);
            }
        }

        if (collision.gameObject.tag == "scoreNambah")
        {
            if (!gameOverText.activeSelf)
            {
                scoreValue += 1;
                score.GetComponent<Text>().text = "" + scoreValue.ToString();
            }
        }
    }

    public void tekanButtonJump()
    {
        buttonJump = true;
    }

    public void tekanButtonNunduk()
    {
        buttonNunduk = true;
    }
    public void lepasButtonNunduk()
    {
        buttonNunduk = false;
    }
}

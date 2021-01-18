using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody2D rb;
    Animator anim;

    public int jump;
    public bool jumping;

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
    }

}

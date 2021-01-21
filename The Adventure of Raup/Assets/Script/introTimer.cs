using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class introTimer : MonoBehaviour
{
    int timer = 0;
    public int batas;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer++;

        if (timer > batas)
        {
            Application.LoadLevel(1);
        }
    }
}

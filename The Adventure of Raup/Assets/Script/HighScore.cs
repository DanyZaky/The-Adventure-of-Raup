using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public GameObject skor;
    void Start()
    {
        
    }

    void Update()
    {
        
        if (gameObject.name == "HighScore")
        {
            GetComponent<Text>().text = "H " + PlayerPrefs.GetInt("highscore").ToString();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public bool buttonRestart, buttonMainMenu, buttonPlay, buttonExit, buttonSetting;
    void Update()
    {
        if (buttonRestart == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (buttonMainMenu == true)
        {
            Application.LoadLevel(0);
        }

        if (buttonPlay == true)
        {
            Application.LoadLevel(1);
        }

        if (buttonExit == true)
        {
            Application.Quit();
        }
    }

    public void tekanButtonRestart()
    {
        buttonRestart = true;
    }
    public void tekanButtonMainMenu()
    {
        buttonMainMenu = true;
    }
    public void tekanButtonPlay()
    {
        buttonPlay = true;
    }
    public void tekanButtonSetting()
    {
        buttonSetting = true;
    }
    public void tekanButtonExit()
    {
        buttonExit = true;
    }
}

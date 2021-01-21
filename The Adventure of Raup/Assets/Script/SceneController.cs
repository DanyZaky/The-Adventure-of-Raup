using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public bool buttonRestart, buttonMainMenu, buttonPlay, buttonExit, buttonSetting, buttonBackSetting, buttonReset;

    public GameObject tampilanSetting, tampilanBackButton, tampilanPlay, viewSetting, viewExit, viewReset;

    public AudioSource touch;
    void Update()
    {
        if (buttonRestart == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (buttonMainMenu == true)
        {
            Application.LoadLevel(1);
            
        }

        if (buttonPlay == true)
        {
            Application.LoadLevel(2);
        }

        if (buttonSetting == true)
        {
            viewSetting.SetActive(false);
            viewExit.SetActive(false);
            viewReset.SetActive(true);
            tampilanSetting.SetActive(true);
            tampilanBackButton.SetActive(true);
            tampilanPlay.SetActive(false);
            
        }

        if (buttonBackSetting == true)
        {
            tampilanSetting.SetActive(false);
            tampilanBackButton.SetActive(false);
            tampilanPlay.SetActive(true);
            viewSetting.SetActive(true);
            viewExit.SetActive(true);
            viewReset.SetActive(false);
        }

        if (buttonExit == true)
        {
            Application.Quit();
        }

        if (buttonReset == true)
        {
            PlayerPrefs.DeleteKey("highscore");
        }
    }

    public void tekanButtonRestart()
    {
        buttonRestart = true;
        touch.Play();
    }
    public void tekanButtonMainMenu()
    {
        buttonMainMenu = true;
        touch.Play();
    }
    public void tekanButtonPlay()
    {
        buttonPlay = true;
        touch.Play();
    }
    public void tekanButtonSetting()
    {
        buttonSetting = true;
        touch.Play();
    }
    public void tekanButtonExit()
    {
        buttonExit = true;
        touch.Play();
    }
    public void tekanButtonBackSetting()
    {
        buttonBackSetting = true;
        touch.Play();
    }

    public void tekanResest()
    {
        buttonReset = true;
        touch.Play();
    }
}

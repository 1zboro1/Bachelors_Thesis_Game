using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonsActions : MonoBehaviour

{

    public GameObject StartUI;
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
    public void HowToPlay()
    {
        SceneManager.LoadScene(2);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Track1()
    {
        SceneManager.LoadScene(3);
    }

    public void Track2()
    {
        SceneManager.LoadScene(4);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void StartRace()
    {
        Time.timeScale = 1.0f;
        PauseScript.GamePaused = false;
        StartUI.SetActive(false);
    }
}

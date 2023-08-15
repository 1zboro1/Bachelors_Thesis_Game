using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseScript : MonoBehaviour
{
    public static bool GamePaused = false;
    public GameObject PauseUI;
    void Resume()
    {
        PauseUI.SetActive(false);
        Time.timeScale = 1.0f;
        GamePaused = false;
    }

    void Pause()
    {
        PauseUI.SetActive(true);
        Time.timeScale = 0.0f;
        GamePaused = true;
    }
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape) && FinishScript.GameFinished == false)
        {
            if (GamePaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
}

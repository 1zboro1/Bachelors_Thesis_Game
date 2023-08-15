using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishScript : MonoBehaviour
{
    [SerializeField] int NumberOfLaps;
    [SerializeField] GameObject FinishPanel;
    public static bool GameFinished = false;
    
    void Update()
    {
        if(LapCompleteScript.LapsDoneFinish >= NumberOfLaps+1)
        {
            FinishPanel.SetActive(true);
            Time.timeScale = 0.0f;
            GameFinished = true;
            return;
        }
    }
}

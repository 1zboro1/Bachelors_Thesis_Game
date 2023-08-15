using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateReset : MonoBehaviour
{
    void Start()
    {
        LapCompleteScript.LapsDone = 1;
        LapCompleteScript.LapsDoneFinish = 1;
        Time.timeScale = 0.0f;
        LapTimeScript.MinCount = 0;
        LapTimeScript.SecCount = 0;
        LapTimeScript.MilisecCount = 0;
        LapTimeScript.RawTime = 0;
        PauseScript.GamePaused = false;
        FinishScript.GameFinished = false;

    }

    void Update()
    {
        
    }
}

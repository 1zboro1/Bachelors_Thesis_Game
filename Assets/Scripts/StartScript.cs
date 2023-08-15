using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartScript : MonoBehaviour
{
    public GameObject StartUI;
    private void Start()
    {
        Time.timeScale = 0.0f;
        PauseScript.GamePaused = true;
        StartUI.SetActive(true);
    }
}

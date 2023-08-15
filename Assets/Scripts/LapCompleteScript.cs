using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapCompleteScript : MonoBehaviour
{
    public GameObject LapCompleteTrigger;
    public GameObject HalfLapTrigger;

    public GameObject MinDisplay;
    public GameObject SecDisplay;
    public GameObject MilisecDisplay;

    public GameObject LapCounter;
    public static int LapsDone = 1;
    public static int LapsDoneFinish = 1;

    public float RawTime;



    void OnTriggerEnter()
    {
        

        RawTime = PlayerPrefs.GetFloat("RawTime");

        if(LapsDone <= 1)
        {
            if (LapTimeScript.SecCount <= 9)
            {
                SecDisplay.GetComponent<Text>().text = "0" + LapTimeScript.SecCount + ".";
            }
            else
            {
                SecDisplay.GetComponent<Text>().text = "" + LapTimeScript.SecCount + ".";
            }

            if (LapTimeScript.MinCount <= 9)
            {
                MinDisplay.GetComponent<Text>().text = "0" + LapTimeScript.MinCount + ".";
            }
            else
            {
                MinDisplay.GetComponent<Text>().text = "" + LapTimeScript.MinCount + ".";
            }

            MilisecDisplay.GetComponent<Text>().text = "" + LapTimeScript.MilisecCount;
        }
        if (LapsDone < 3)
        {
            LapsDone += 1;
        }

        LapsDoneFinish += 1;

        if (LapTimeScript.RawTime <= RawTime)
        {

            if (LapTimeScript.SecCount <= 9)
            {
                SecDisplay.GetComponent<Text>().text = "0" + LapTimeScript.SecCount + ".";
            }
            else
            {
                SecDisplay.GetComponent<Text>().text = "" + LapTimeScript.SecCount + ".";
            }

            if (LapTimeScript.MinCount <= 9)
            {
                MinDisplay.GetComponent<Text>().text = "0" + LapTimeScript.MinCount + ".";
            }
            else
            {
                MinDisplay.GetComponent<Text>().text = "" + LapTimeScript.MinCount + ".";
            }

            MilisecDisplay.GetComponent<Text>().text = "" + LapTimeScript.MilisecCount;
        }

        PlayerPrefs.SetInt("MinSave", LapTimeScript.MinCount);
        PlayerPrefs.SetInt("SecSave", LapTimeScript.SecCount);
        PlayerPrefs.SetFloat("MilisecSave", LapTimeScript.MilisecCount);
        PlayerPrefs.SetFloat("RawTime", LapTimeScript.RawTime);

        LapTimeScript.MinCount = 0;
        LapTimeScript.SecCount = 0;
        LapTimeScript.MilisecCount = 0;
        LapTimeScript.RawTime = 0;
        LapCounter.GetComponent<Text>().text = "" + LapsDone;

        HalfLapTrigger.SetActive(true);
        LapCompleteTrigger.SetActive(false);
    }
    
}

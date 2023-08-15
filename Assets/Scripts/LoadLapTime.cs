using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadLapTime : MonoBehaviour
{
    public int MinCount;
    public int SecCount;
    public float MilisecCount;
    public GameObject MinDisp;
    public GameObject SecDisp;
    public GameObject MilisecDisp;
    public GameObject LapCounter;

    void Start()
    {
        LapCounter.GetComponent<Text>().text = "1";
        PlayerPrefs.DeleteAll();
        MinCount = PlayerPrefs.GetInt("MinSave");
        SecCount = PlayerPrefs.GetInt("SecSave");
        MilisecCount = PlayerPrefs.GetFloat("MilisecSave");

        MinDisp.GetComponent<Text>().text = "0" + MinCount + ":";
        SecDisp.GetComponent<Text>().text = "0" + SecCount + ".";
        MilisecDisp.GetComponent<Text>().text = "0" + MilisecCount;
    }

}

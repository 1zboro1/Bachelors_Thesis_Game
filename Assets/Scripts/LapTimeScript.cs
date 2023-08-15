using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTimeScript : MonoBehaviour
{
    public static int MinCount;
    public static int SecCount;
    public static float MilisecCount;
    public static string MilisecDisplay;
    public GameObject MinBox;
    public GameObject SecBox;
    public GameObject MilisecBox;

    public static float RawTime;

    void Update()
    {
        MilisecCount += Time.deltaTime * 10;
        RawTime += Time.deltaTime;
        MilisecDisplay = MilisecCount.ToString("F0");
        MilisecBox.GetComponent<Text>().text = "" + MilisecDisplay;

        if(MilisecCount >= 10)
        {
            MilisecCount = 0;
            SecCount += 1;
        }

        if(SecCount <= 9)
        {
            SecBox.GetComponent<Text>().text = "0" + SecCount + ".";
        }
        else
        {
            SecBox.GetComponent<Text>().text = "" + SecCount + ".";
        }

        if(SecCount >= 60)
        {
            SecCount = 0;
            MinCount += 1;
        }

        if(MinCount <= 9)
        {
            MinBox.GetComponent<Text>().text = "0" + MinCount + ":";
        }
        else
        {
            MinBox.GetComponent<Text>().text = "" + MinCount + ":";
        }
    }
}

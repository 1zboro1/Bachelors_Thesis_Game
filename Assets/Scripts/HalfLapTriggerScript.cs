using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfLapTriggerScript : MonoBehaviour
{
    public GameObject CompleteLapTrigger;
    public GameObject HalfLapTrigger;

    void OnTriggerEnter()
    {
        CompleteLapTrigger.SetActive(true);
        HalfLapTrigger.SetActive(false);
    }
}

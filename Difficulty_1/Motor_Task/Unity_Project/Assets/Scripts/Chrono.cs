using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class Chrono : MonoBehaviour
{
    public Text timeCounter;

    public TimeSpan timePlaying;

    public float elapsedTime;

    string timePlayingStr;

    public bool go;

    // Start is called before the first frame update
    void Start()
    {
        go = false;
        timeCounter.text = "Time: 00:00.00";
    }

    // Update is called once per frame
    void Update()
    {
        if (go)
        {
            elapsedTime += Time.deltaTime;
            timePlaying = TimeSpan.FromSeconds(elapsedTime);
            timePlayingStr = "Time: " + timePlaying.ToString("mm':'ss'.'ff");
            timeCounter.text = timePlayingStr;
        }
    }
}

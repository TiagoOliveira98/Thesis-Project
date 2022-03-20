using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoMinutes : MonoBehaviour
{
    public GameObject timer;
    public GameObject dataLog;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer.GetComponent<Chrono>().elapsedTime > 60f)
        {
            //dataLog.GetComponent<DataLogs>().close = true;
            Application.Quit();
            //UnityEditor.EditorApplication.isPlaying = false;
        }
    }
}

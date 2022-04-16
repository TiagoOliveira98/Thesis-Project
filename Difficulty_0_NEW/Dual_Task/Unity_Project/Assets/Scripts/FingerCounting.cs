using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FingerCounting : MonoBehaviour
{
    public float time;

    public int fingers;

    public GameObject indexTip, indexJoint, middleTip, middleJoint, ringTip, ringJoint, pinkyTip, pinkyJoint;
    public GameObject indexTip2, indexJoint2, middleTip2, middleJoint2, ringTip2, ringJoint2, pinkyTip2, pinkyJoint2;
    public GameObject thumbTip, thumbJoint;
    public GameObject thumbTip2, thumbJoint2;


    // Start is called before the first frame update
    void Start()
    {
        fingers = 0;
        //time = 0f;
        //selection = -1;
        //numberSelection = 1;

        //vector = new int[10];
        //for(int i = 0; i<10; i++)
        //{
        //    vector[i] = 0;
        //}
        //selections = new int[2];
    }

    // Update is called once per frame
    void Update()
    {
        //Obtain the last and newest value chosen
        fingerCount();

    }

    //Count the number of fingers up
    void fingerCount()
    {
        fingers = 0;

        //Index Fingers
        if (indexTip.transform.position.y > indexJoint.transform.position.y)
        {
            fingers+=1;
        }
        if (indexTip2.transform.position.y > indexJoint2.transform.position.y)
        {
            fingers += 1;
        }

        //Middle Fingers
        if (middleTip.transform.position.y > middleJoint.transform.position.y)
        {
            fingers += 1;
        }
        if (middleTip2.transform.position.y > middleJoint2.transform.position.y)
        {
            fingers += 1;
        }

        //Ring Fingers
        if (ringTip.transform.position.y > ringJoint.transform.position.y)
        {
            fingers += 1;
        }
        if (ringTip2.transform.position.y > ringJoint2.transform.position.y)
        {
            fingers += 1;
        }

        //Pinky Fingers
        if (pinkyTip.transform.position.y > pinkyJoint.transform.position.y)
        {
            fingers += 1;
        }
        if (pinkyTip2.transform.position.y > pinkyJoint2.transform.position.y)
        {
            fingers += 1;
        }

        //Right Thumb
        if (thumbTip.transform.position.x < thumbJoint.transform.position.x)
        {
            fingers += 1;
        }

        //Left Thumb
        if (thumbTip2.transform.position.x > thumbJoint2.transform.position.x)
        {
            fingers += 1;
        }
    }
}

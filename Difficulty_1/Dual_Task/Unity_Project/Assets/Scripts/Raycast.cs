using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    public GameObject fingerJointRight, fingerTipRight;
    public GameObject fingerJointLeft, fingerTipLeft;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Physics.Raycast(fingerTipRight.transform.position, fingerTipRight.transform.position - fingerJointRight.transform.position);
        Physics.Raycast(fingerTipLeft.transform.position, fingerTipLeft.transform.position - fingerJointLeft.transform.position);

        Debug.DrawRay(fingerTipRight.transform.position, (fingerTipRight.transform.position - fingerJointRight.transform.position) * 100, Color.green);
        Debug.DrawRay(fingerTipLeft.transform.position, (fingerTipLeft.transform.position - fingerJointLeft.transform.position) * 100, Color.green);
    }
}

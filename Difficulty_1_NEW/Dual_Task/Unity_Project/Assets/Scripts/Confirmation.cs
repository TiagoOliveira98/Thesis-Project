using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Confirmation : MonoBehaviour
{
    GameObject cameras;
    Points points;

    //Debug
    public string[] auxString;
    public int sizeDebug;

    public Text Text;

    //public Text lives;

    public int size;

    public string heart;

    //Variable with the initial equation created by the Calculator script
    public static string initial;

    //Variable that stores the current answer to be confirmed
    //public static string answer;
    public static int answer;
    public int a;

    //Variable to store the solution that it is got from Calculator script
    public string solution;

    //Variable that signals that the answer was correct or not. Serves to communicate with the Calculator script to create a new equation
    public static bool correct;

    //GameObject for the screen of the calculator
    public GameObject screen;

    //Variable that allows the confoirmation of new answers
    public bool canConfirm;

    string latest;

    // Start is called before the first frame update
    void Start()
    {
        //initial = null;
        //Initialize variables
        answer = -1;
        //Check the name of the object attached and give the correspondent value
        if(name == "Enter")
        {
            answer = 1;
        }
        else if(name == "Clear(CE)")
        {
            answer = 0;
        }
        a = answer;
        solution = null;
        correct = false;
        canConfirm = false;

        cameras = GameObject.Find("Main Camera");
        points = cameras.GetComponent<Points>();

        //latest = Text.GetComponent<Text>().text;
    } 

    // Update is called once per frame
    void Update()
    {
        Text.GetComponent<Text>().text = "Points: " + points.point;
    }

    public void StartIn()
    {
        GetComponent<Collider>().enabled = false;

        transform.localPosition = new Vector3(transform.localPosition.x, -0.2f, transform.localPosition.z);

        Invoke("ResetIn", 1);
    }

    public void ResetIn()
    {
        transform.localPosition = new Vector3(transform.localPosition.x, 0f, transform.localPosition.z);
        GetComponent<Collider>().enabled = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        //Verify if there was a collsion with a finger tip and if there is already input to confirm
        if ((other.name == "INDEX_FINGER_TIP" || other.name == "INDEX_FINGER_TIP2") /*&& canConfirm == true*/)
        {
            if (GameObject.Find("Calculator").GetComponent<Calculator>().even == false)
            {
                GameObject.Find("StroopTest").GetComponent<Stroop>().change = 1;
                GameObject.Find("StroopTest").GetComponent<Stroop>().errors += 1;
                GameObject.Find("StroopTest").GetComponent<Stroop>().evenErrors += 1;

                GameObject.Find("StroopTest").GetComponent<Stroop>().numberEquations += 1;

                return;
            }

            //Get the solution to the problem created in teh Calculator object script
            //solution = GameObject.Find("Calculator").gameObject.GetComponent<Calculator>().solution;

            StartIn();
            //if (GameObject.Find("StroopTest").GetComponent<Stroop>().allow == 1)
            //{
                //int answer1 = answer;
                if (a == GameObject.Find("Calculator").gameObject.GetComponent<Calculator>().check)
                {
                    //Debug.Log("HERE");
                    GameObject.Find("Calculator").gameObject.GetComponent<Calculator>().correct = true;
                    points.point += 1;

                    //correct = true;
                    //answer = -1;
                    GameObject.Find("StroopTest").GetComponent<Stroop>().numberEquations += 1;

                }
                else
                {
                    //NEW
                    GameObject.Find("StroopTest").GetComponent<Stroop>().change = 1;
                    GameObject.Find("StroopTest").GetComponent<Stroop>().errors += 1;
                    GameObject.Find("StroopTest").GetComponent<Stroop>().wrongErrors += 1;
                    GameObject.Find("StroopTest").GetComponent<Stroop>().numberEquations += 1;
                    //points.point = 0;
                }
            //}
            //else
            //{
            //    if (points.point > 0)
            //        points.point -= 1;
            //    else
            //        points.point = 0;
            //}
            
            //Disable confirmations after entering aan answer
            //////canConfirm = false;
        }
    }
}

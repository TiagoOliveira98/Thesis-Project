using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stroop : MonoBehaviour
{
    public float time, t;
    public Text stroop;
    public int equal;
    public string color1, color2;

    int check;
    int a;

    public int allow;

    public int errors;

    public int change;

    public int numberEquations;

    public int wasCorrect;

    GameObject cameras;
    Points points;

    //public Text s;

    // Start is called before the first frame update
    void Start()
    {
        cameras = GameObject.Find("Main Camera");
        points = cameras.GetComponent<Points>();

        time = 0f;
        check = 1;
        allow = 1;
        errors = 0;
        change = 0;
        numberEquations = 0;
        wasCorrect = 0;

        a = 0;
    }

    void StroopFunction()
    {
        check = 1;
        //Red, Yellow, Green, Purple, Blue
        int aux = Random.Range(0, 8);
        if (aux == 4)
        {
            color1 = "red";
        }
        else if (aux == 5)
        {
            color1 = "yellow";
        }
        /*else if (aux == 3)
        {
            color1 = "green";
        }*/
        else if (aux == 6)
        {
            color1 = "purple";
        }
        else if (aux == 7)
        {
            color1 = "blue";
        }
        else
        {
            color1 = "green";
        }

        equal = Random.Range(0, 3);
        if (equal == 0 || equal == 1)
        {
            if (stroop != null)
                stroop.text = "<color=" + color1 + ">GREEN</color> ";
            allow = 1;
        }
        else
        {
            allow = 0;

            aux = Random.Range(1, 5);
            if (aux == 1)
            {
                color2 = "RED";
            }
            else if (aux == 2)
            {
                color2 = "YELLOW";
            }
            else if (aux == 3)
            {
                color2 = "PURPLE";
            }
            else if (aux == 4)
            {
                color2 = "BLUE";
            }
            if (stroop != null)
                stroop.text = "<color=" + color1 + ">" + color2 + "</color>";
        }

    }

    void ChangeEquation()
    {
        //if (GameObject.Find("Chronometer").GetComponent<Chrono>().elapsedTime > 0 && check == 1)
        //{
            /*if (a == 0)
            {
                if (stroop != null)
                    stroop.GetComponent<RectTransform>().localScale = new Vector3(2f, 2f, 1f);
                a = 1;
            }*/

            change = 1;

        //}
    }

        // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("Chronometer").GetComponent<Chrono>().elapsedTime > 0)
            time += Time.deltaTime;
            /*if (GameObject.Find("Chronometer").GetComponent<Chrono>().elapsedTime > 0 && check == 1)
            {
                if(a==0)
                {
                    if(stroop != null)
                        stroop.GetComponent<RectTransform>().localScale = new Vector3(2f, 2f, 1f);
                    a = 1;
                }
            
                check = 0;
                Invoke("StroopFunction", 5);
          
            }*/
        if(GameObject.Find("Chronometer").GetComponent<Chrono>().elapsedTime > 0 /*&& check == 1*/ && time > 3f)
        {
            if(Confirmation.answer == "" && GameObject.Find("Calculator").GetComponent<Calculator>().even == false)
            {
                points.point += 1;
            }
            else if(Confirmation.answer != "" && GameObject.Find("Calculator").GetComponent<Calculator>().even == false)
            {
                //points.point -= 1;
                errors += 1;
            }
            else if(Confirmation.answer == "" && GameObject.Find("Calculator").GetComponent<Calculator>().even == true)
            {
                errors += 1;
            }
            //check = 0;
            //Invoke("ChangeEquation", 3);
            ChangeEquation();
            
            //errors += 1;
            numberEquations += 1;
        }
            
        if(numberEquations == 20)
        {
            Application.Quit();
        }
    }
}

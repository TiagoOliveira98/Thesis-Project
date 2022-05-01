using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ConfirmCog : MonoBehaviour
{
    Points points;
    GameObject cameras;

    public string solution;

    public bool pushDown;

    public GameObject screen;

    public int a;

    // Start is called before the first frame update
    void Start()
    {
        cameras = GameObject.Find("Main Camera");
        points = cameras.GetComponent<Points>();
        //ADDED
        if(name == "Confirm")
        {
            a = 1;
        }
        else if(name == "Delete")
        {
            a = 0;
        }
        

        pushDown = true;
    }

    // Update is called once per frame
    void Update()
    {

        if(a==1)
        {
            if (/*Input.GetKeyDown(KeyCode.Return)*/Input.GetKeyDown(KeyCode.RightArrow) == true)
            {
                PushButton();
            }
        }
        else
        {
            if (/*Input.GetKeyDown(KeyCode.Delete)*/ Input.GetKeyDown(KeyCode.LeftArrow) == true)
            {
                PushButton();
            }
        }
        
    }

    public void ResetIn()
    {
        //Vector3 v = transform.position;
        GameObject aux;
        if (a == 1)
            aux = GameObject.Find("Enter");
        else
            aux = GameObject.Find("Clear(CE)");
        //v.y = 0f;
        //GameObject aux = GameObject.Find("Enter");
        aux.transform.localPosition = new Vector3(aux.transform.localPosition.x, 0f, aux.transform.localPosition.z);
        pushDown = true;
    }

    public void StartIn()
    {
        pushDown = false;
        GameObject aux;
        if(a==1)
            aux = GameObject.Find("Enter");
        else
            aux = GameObject.Find("Clear(CE)");

        aux.transform.localPosition = new Vector3(aux.transform.localPosition.x, -0.2f, aux.transform.localPosition.z);

        Invoke("ResetIn", 1);
    }

    public void PushButton()
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

        //Case if the answer and solution are the same
        //if (GameObject.Find("StroopTest").GetComponent<Stroop>().allow == 1)
        //{
            if (/*Confirmation.answer*/a == GameObject.Find("Calculator").gameObject.GetComponent<Calculator>().check)
            {
                GameObject.Find("Calculator").gameObject.GetComponent<Calculator>().correct = true;
                points.point += 1;

                //Debug.Log(answer);
                //Reset the answer
                //Confirmation.answer = -1;
                //screen.GetComponent<TextMesh>().text = "Correct";
                //Render another operation

                //Give a Point or somethig similar/ Progress bar
                //correct = true;

                //Text.GetComponent<Text>().text = latest;
                GameObject.Find("StroopTest").GetComponent<Stroop>().numberEquations += 1;

            }
            else
            {
                //NEW
                GameObject.Find("StroopTest").GetComponent<Stroop>().change = 1;
                GameObject.Find("StroopTest").GetComponent<Stroop>().errors += 1;
                GameObject.Find("StroopTest").GetComponent<Stroop>().wrongErrors += 1;
                GameObject.Find("StroopTest").GetComponent<Stroop>().numberEquations += 1;
            }
        //}
        //else
        //{
            //NEW
        //    if (points.point > 0)
        //        points.point -= 1;
        //    else
        //        points.point = 0;
        //}
        /*else
        {
            screen.GetComponent<TextMesh>().text = GameObject.Find("Calculator").gameObject.GetComponent<Calculator>().initial;
            //Debug.Log(answer);
            //Debug.Log(solution);
            //////////////Text aux = lives.GetComponent<Text>();
            //////////////size = aux.text.Length;

            //Reset the answer
            Confirmation.answer = -1;
            //Render the same operation
            //Maybe set a group of 3 hearts and take one of them out for each wrong answer
            
            /*
            if (aux.text.Length == 1)
            {
                //No more lives left
                //Reset points
                //points.point = 0;

                //Test
                GameObject.Find("Calculator").gameObject.GetComponent<Calculator>().correct = true;

                points.point = 0;
                aux.text = "";
                for (int i = 0; i < 5; i++)
                {
                    if (i == 0)
                        aux.text += heart;
                    else
                    {
                        aux.text += ' ';
                        aux.text += heart;
                    }
                }
                auxString = null;
            }
            else
            {
                //aux.text = aux.text.Remove(aux.text.Length - 3);
                //aux.text = string.Replace(heart, aux.text);
                //TEST
                auxString = aux.text.Split(' ');
                sizeDebug = auxString.Length;

                //if(auxString.Length > 1)
                //{
                aux.text = "";
                for (int i = 0; i < auxString.Length - 1; i++)
                {
                    if (i == 0)
                        aux.text += heart;
                    else
                    {
                        aux.text += ' ';
                        aux.text += heart;
                    }

                }
                //}
                //else
                //{
                //    points.point = 0;
                //    aux.text = "";
                //    for (int i = 0; i < 5; i++)
                //    {
                //        if (i == 0)
                //            aux.text += heart;
                //        else
                //        {
                //            aux.text += ' ';
                //            aux.text += heart;
                //        }
                //    }
                //    auxString = null;
                //}
            }

        }*/
        //Disable confirmations after entering aan answer
        //canConfirm = false;
    }
}

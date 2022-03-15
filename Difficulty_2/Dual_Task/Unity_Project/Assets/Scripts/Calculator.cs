using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    public string initial;
    public string solution;
    public bool correct;

    public GameObject screen;

    // Start is called before the first frame update
    void Start()
    {
        //solution = "15";
        //initial = "3 x 5 = __";
        //Confirmation.initial = initial;
        correct = true;
    }

    // Update is called once per frame
    void Update()
    {
        //GameObject.Find("Confirmation").gameObject.GetComponent<Confirmation>().solution = solution;
        //GameObject.Find("Confirmation").gameObject.GetComponent<Confirmation>().initial = initial;
        if(correct == true)
        {
            initial = GenerateEquation();
            screen.GetComponent<TextMesh>().text = initial;
            correct = false;
        }
    }

    string GenerateEquation()
    {
        int num1, num2, ans;
        //string str;
        
        //1 -> Multiplication; 2 -> Addition; 3 -> Subtraction
        int operation = Random.Range(1, 4);
        if(operation == 1)
        {
            num1 = Random.Range(0, 10);
            num2 = Random.Range(0, 10);

            ans = num1 * num2;
            //solution = ans.ToString();

            int parcel = Random.Range(1, 4);
            if (parcel == 1)
            {
                //Added
                while (num2 == ans && num2 == 0)
                {
                    num1 = Random.Range(0, 10);
                    num2 = Random.Range(0, 10);

                    ans = num1 * num2;
                }

                solution = num1.ToString();
            }
            else if (parcel == 2)
            {
                //Added
                while (num1 == ans && num1 == 0)
                {
                    num1 = Random.Range(0, 10);
                    num2 = Random.Range(0, 10);

                    ans = num1 * num2;
                }

                solution = num2.ToString();
            }
            else if (parcel == 3)
            {
                solution = ans.ToString();
            }

            return (CreateString(num1, num2, ans, 'x', parcel));
        }
        else if(operation==2)
        {
            num1 = Random.Range(0, 40);
            num2 = Random.Range(0, 40);
            ans = num1 + num2;

            int parcel = Random.Range(1, 4);
            if (parcel == 1)
            {
                solution = num1.ToString();
            }
            else if (parcel == 2)
            {
                solution = num2.ToString();
            }
            else if (parcel == 3)
            {
                solution = ans.ToString();
            }

            //solution = ans.ToString();

            return (CreateString(num1, num2, ans, '+', parcel));
        }
        else
        {
            int aux = Random.Range(0, 40);
            int aux2 = Random.Range(0, 40);
            if(aux >= aux2)
            {
                num1 = aux;
                num2 = aux2;
            }
            else
            {
                num1 = aux2;
                num2 = aux;
            }

            ans = num1 - num2;
            /*solution = ans.ToString();
            string n1 = num1.ToString();
            string n2 = num2.ToString();*/
            int parcel = Random.Range(1, 4);
            if (parcel == 1)
            {
                solution = num1.ToString();
            }
            else if (parcel == 2)
            {
                solution = num2.ToString();
            }
            else if (parcel == 3)
            {
                solution = ans.ToString();
            }

            return (CreateString(num1, num2, ans, '-',parcel));
        }

    }

    string CreateString(int n1, int n2, int ans, char opt, int parcel)
    {
        string strg;

        if (parcel == 1)
        {
            if (n1 < 10)
            {
                strg = "_ " + opt + " " + n2.ToString() + " = " + ans.ToString();
            }
            else
            {
                strg = "__ " + opt + " " + n2.ToString() + " = " + ans.ToString();
            }
        }
        else if (parcel == 2)
        {
            if (n2 < 10)
            {
                strg = n1.ToString() + " " + opt + " _ = " + ans.ToString();
            }
            else
            {
                strg = n1.ToString() + " " + opt + " __ = " + ans.ToString();
            }
        }
        else
        {
            if (ans < 10)
            {
                strg = n1.ToString() + " " + opt + " " + n2.ToString() + " =  _";
            }
            else
            {
                strg = n1.ToString() + " " + opt + " " + n2.ToString() + " =  __";
            }
        }

        return strg;
    }
}

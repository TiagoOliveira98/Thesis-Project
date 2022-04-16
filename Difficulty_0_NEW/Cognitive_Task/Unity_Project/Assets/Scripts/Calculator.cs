using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    public string initial;
    public string solution;
    public bool correct;

    public int check;

    public string[] aux;
    public bool[] auxEven;
    public int[] auxCheck;

    public GameObject screen;

    public int i;

    public bool even;

    // Start is called before the first frame update
    void Start()
    {
        //solution = "15";
        //initial = "3 x 5 = __";
        //Confirmation.initial = initial;
        correct = true;

        aux = new string[20];
        auxEven = new bool[20];
        auxCheck = new int[20];

        i = 0;

        EquationVector();
    }

    // Update is called once per frame
    void Update()
    {
        //GameObject.Find("Confirmation").gameObject.GetComponent<Confirmation>().solution = solution;
        //GameObject.Find("Confirmation").gameObject.GetComponent<Confirmation>().initial = initial;
        if(correct == true || GameObject.Find("StroopTest").GetComponent<Stroop>().change == 1)
        {
            if (i == 20)
                Application.Quit();
            initial = GenerateEquation();
            screen.GetComponent<TextMesh>().text = initial;
            correct = false;

            GameObject.Find("StroopTest").GetComponent<Stroop>().change = 0;
            GameObject.Find("StroopTest").GetComponent<Stroop>().time = 0f;
        }
    }

    void EquationVector()
    {
        aux[0] = "3 + 4 = 7";
        aux[1] = "0 + 4 = 6";
        aux[2] = "3 + 5 = 10";
        aux[3] = "0 + 7 = 9";
        aux[4] = "6 + 2 = 10";
        aux[5] = "5 + 5 = 13";
        aux[6] = "3 + 6 = 9";
        aux[7] = "4 + 9 = 13";
        aux[8] = "1 + 5 = 4";
        aux[9] = "8 + 9 = 17";
        aux[10] = "2 + 5 = 9";
        aux[11] = "9 + 9 = 18";
        aux[12] = "3 + 7 = 11";
        aux[13] = "4 + 4 = 8";
        aux[14] = "2 + 5 = 7";
        aux[15] = "1 + 8 = 7";
        aux[16] = "9 + 5 = 15";
        aux[17] = "5 + 4 = 10";
        aux[18] = "3 + 9 = 12";
        aux[19] = "2 + 1 = 3";

        auxEven[0] = false;
        auxEven[1] = true;
        auxEven[2] = true;
        auxEven[3] = false;
        auxEven[4] = true;
        auxEven[5] = true;
        auxEven[6] = false;
        auxEven[7] = false;
        auxEven[8] = true;
        auxEven[9] = false;
        auxEven[10] = false;
        auxEven[11] = true;
        auxEven[12] = true;
        auxEven[13] = true;
        auxEven[14] = false;
        auxEven[15] = false;
        auxEven[16] = true;
        auxEven[17] = false;
        auxEven[18] = true;
        auxEven[19] = false;

        auxCheck[0] = 1;
        auxCheck[1] = 0;
        auxCheck[2] = 0;
        auxCheck[3] = 0;
        auxCheck[4] = 0;
        auxCheck[5] = 0;
        auxCheck[6] = 1;
        auxCheck[7] = 1;
        auxCheck[8] = 0;
        auxCheck[9] = 1;
        auxCheck[10] = 0;
        auxCheck[11] = 1;
        auxCheck[12] = 0;
        auxCheck[13] = 1;
        auxCheck[14] = 1;
        auxCheck[15] = 0;
        auxCheck[16] = 0;
        auxCheck[17] = 0;
        auxCheck[18] = 1;
        auxCheck[19] = 1;

    }

    string GenerateEquation()
    {
        even = auxEven[i];
        check = auxCheck[i];
        i += 1;
        return aux[i-1];
    }


    //string GenerateEquation()
    //{
    //    int num1, num2, ans;
    //    //string str;
    //    
    //    //1 -> Multiplication; 2 -> Addition; 3 -> Subtraction
    //    int operation = Random.Range(1, 4);
    //   if(operation == 1)
    //    {
    //        /*num1 = Random.Range(0, 10);
    //        num2 = Random.Range(0, 10);
    //
    //        ans = num1 * num2;*/
    //        int ansAux;
    //        num1 = Random.Range(0, 10);
    //        num2 = Random.Range(0, 10);
    //
    //        ans = num1 * num2;
    //        /**solution = ans.ToString();
    //
    //        return (CreateString(num1.ToString(), num2.ToString(), ans, 'x'));**/
    //        check = Random.Range(0, 2);
    //        if (check == 0)
    //        {
    //            //Create a wrong answer
    //            ansAux = ans + Random.Range(-10, 11);
    //            while (ansAux < 0)
    //            {
    //                ansAux = ans + Random.Range(-10, 11);
    //            }
    //            ans = ansAux;
    //            //solution 

    //            string n1 = num1.ToString();
    //            string n2 = num2.ToString();

    //            return (CreateString(n1, n2, ans, 'x'));
    //        }
    //        else
    //        {
    //            string n1 = num1.ToString();
    //            string n2 = num2.ToString();

    //            return (CreateString(n1, n2, ans, 'x'));
    //        }
            //Rephrase the code above
    //    }
    //    else if(operation==2)
    //    {
    //        /*num1 = Random.Range(0, 40);
    //        num2 = Random.Range(0, 40);
    //        ans = num1 + num2;*/
    //        int ansAux;
    //        num1 = Random.Range(0, 40);
    //        num2 = Random.Range(0, 40);
    //        ans = num1 + num2;
    //        /**solution = ans.ToString();
    //
    //        return (CreateString(num1.ToString(), num2.ToString(), ans, '+'));**/
    //        check = Random.Range(0, 2);
    //        if (check == 0)
    //        {
    //            //Create a wrong answer
    //            ansAux = ans + Random.Range(-10, 11);
    //            while (ansAux < 0)
    //            {
    //                ansAux = ans + Random.Range(-10, 11);
    //            }
    //            ans = ansAux;
    //            //solution 

    //            string n1 = num1.ToString();
    //            string n2 = num2.ToString();

    //            return (CreateString(n1, n2, ans, '+'));
    //        }
    //        else
    //        {
    //            string n1 = num1.ToString();
    //            string n2 = num2.ToString();

    //            return (CreateString(n1, n2, ans, '+'));
    //        }
    //        //Rephrase the code above
    //    }
    //    else
    //    {
    //        int ansAux;
    //        int aux = Random.Range(0, 40);
    //        int aux2 = Random.Range(0, 40);
    //        if(aux >= aux2)
    //        {
    //            num1 = aux;
    //            num2 = aux2;
    //        }
    //        else
    //        {
    //            num1 = aux2;
    //            num2 = aux;
    //        }
    //
    //        ans = num1 - num2;
    //
    //        check = Random.Range(0, 2);
    //        if (check == 0)
    //        {
    //            //Create a wrong answer
    //            ansAux = ans + Random.Range(-20, 21);
    //            while (ansAux < 0 || ansAux == ans )
    //            {
    //                ansAux = ans + Random.Range(-20, 21);
    //            }
    //            ans = ansAux;
    //            //solution 
    //
    //            string n1 = num1.ToString();
    //            string n2 = num2.ToString();

    //            return (CreateString(n1, n2, ans, '-'));
    //        }
    //        else
    //        {
    //            string n1 = num1.ToString();
    //            string n2 = num2.ToString();
    //
    //            return (CreateString(n1, n2, ans, '-'));
    //        }
    //        //Rephrase the code above



            /**solution = ans.ToString();
            string n1 = num1.ToString();
            string n2 = num2.ToString();

            return (CreateString(n1, n2, ans, '-'));*/
    //    }

    //}

    string CreateString(string n1, string n2, int ans, char opt)
    {
        string str;

        if (ans < 10)
        {

            str = n1 + " " + opt + " " + n2 + " = " + ans.ToString();
        }
        else
        {
            str = n1 + " " + opt + " " + n2 + " = " + ans.ToString();
        }

        return str;
    }
}

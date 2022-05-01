using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    public string initial;
    public string solution;
    public bool correct;

    public int check;

    public Text answerType;

    public GameObject screen;

    public string[] aux;
    public bool[] auxEven;
    public int[] auxCheck;
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
        if(correct == true )
        {
            if(i == 20)
            {
                UnityEditor.EditorApplication.isPlaying = false;
                //Application.Quit();
            }
            initial = GenerateEquationNew();
            if(check == 0)
            {
                answerType.GetComponent<Text>().text = "The answer is: <color=red>WRONG</color>";
            }
            else
            {
                answerType.GetComponent<Text>().text = "The answer is: <color=green>RIGHT</color>";
            }
            screen.GetComponent<TextMesh>().text = initial;
            correct = false;
        }
    }

    void EquationVector()
    {
        aux[0] = "1 + 9 + 0 = 10";
        aux[1] = "7 + 8 + 8 = 23";
        aux[2] = "0 + 3 + 2 = 5";
        aux[3] = "8 + 4 + 9 = 18";
        aux[4] = "1 + 2 + 1 = 3";
        aux[5] = "1 + 8 + 5 = 10";
        aux[6] = "5 + 1 + 8 = 14";
        aux[7] = "6 + 3 + 5 = 14";
        aux[8] = "4 + 0 + 2 = 6";
        aux[9] = "1 + 1 + 2 = 4";
        aux[10] = "4 + 0 + 9 = 11";
        aux[11] = "9 + 4 + 4 = 13";
        aux[12] = "3 + 9 + 3 = 19";
        aux[13] = "1 + 7 + 3 = 10";
        aux[14] = "2 + 4 + 0 = 6";
        aux[15] = "1 + 9 + 9 = 20";
        aux[16] = "5 + 0 + 2 = 7";
        aux[17] = "3 + 8 + 0 = 11";
        aux[18] = "0 + 1 + 6 = 6";
        aux[19] = "7 + 6 + 4 = 17";

        /*auxEven[0] = false;
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
        auxEven[19] = false;*/

        auxCheck[0] = 1;
        auxCheck[1] = 1;
        auxCheck[2] = 1;
        auxCheck[3] = 0;
        auxCheck[4] = 0;
        auxCheck[5] = 0;
        auxCheck[6] = 1;
        auxCheck[7] = 1;
        auxCheck[8] = 1;
        auxCheck[9] = 1;
        auxCheck[10] = 0;
        auxCheck[11] = 0;
        auxCheck[12] = 0;
        auxCheck[13] = 0;
        auxCheck[14] = 1;
        auxCheck[15] = 0;
        auxCheck[16] = 1;
        auxCheck[17] = 1;
        auxCheck[18] = 0;
        auxCheck[19] = 1;

    }

    string GenerateEquationNew()
    {
        if (i < 20)
        {
            check = auxCheck[i];
            i += 1;
            return aux[i - 1];
        }

        return null;
    }


    string GenerateEquation()
    {
        int num1, num2, ans;
        //string str;
        
        //1 -> Multiplication; 2 -> Addition; 3 -> Subtraction
        int operation = Random.Range(1, 4);
        if(operation == 1)
        {
            int ansAux;
            num1 = Random.Range(0, 10);
            num2 = Random.Range(0, 10);

            ans = num1 * num2;
            solution = ans.ToString();

            //Solution to type
            //answerType.GetComponent<Text>().text = "Type the number: " + solution;

            //return (CreateString(num1.ToString(), num2.ToString(), ans, 'x'));
            check = Random.Range(0, 2);
            if (check == 0)
            {
                //Create a wrong answer
                ansAux = ans + Random.Range(-10, 11);
                while (ansAux < 0)
                {
                    ansAux = ans + Random.Range(-10, 11);
                }
                ans = ansAux;
                //solution 

                string n1 = num1.ToString();
                string n2 = num2.ToString();

                return (CreateString(n1, n2, ans, 'x'));
            }
            else
            {
                string n1 = num1.ToString();
                string n2 = num2.ToString();

                return (CreateString(n1, n2, ans, 'x'));
            }
            //Rephrase the code above
        }
        else if(operation==2)
        {
            int ansAux;
            num1 = Random.Range(0, 40);
            num2 = Random.Range(0, 40);
            ans = num1 + num2;
            solution = ans.ToString();

            //Solution to type
            //answerType.GetComponent<Text>().text = "Type the number: " + solution;

            check = Random.Range(0, 2);
            if (check == 0)
            {
                //Create a wrong answer
                ansAux = ans + Random.Range(-20, 21);
                while (ansAux < 0 || ansAux == ans)
                {
                    ansAux = ans + Random.Range(-20, 21);
                }
                ans = ansAux;
                //solution 

                string n1 = num1.ToString();
                string n2 = num2.ToString();

                return (CreateString(n1, n2, ans, '+'));
            }
            else
            {
                string n1 = num1.ToString();
                string n2 = num2.ToString();

                return (CreateString(n1, n2, ans, '+'));
            }
            //Rephrase the code above
            //return (CreateString(num1.ToString(), num2.ToString(), ans, '+'));
        }
        else
        {
            int ansAux;
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

            check = Random.Range(0, 2);
            if (check == 0)
            {
                //Create a wrong answer
                ansAux = ans + Random.Range(-10, 11);
                while (ansAux < 0)
                {
                    ansAux = ans + Random.Range(-10, 11);
                }
                ans = ansAux;
                //solution 

                string n1 = num1.ToString();
                string n2 = num2.ToString();

                return (CreateString(n1, n2, ans, '-'));
            }
            else
            {
                string n1 = num1.ToString();
                string n2 = num2.ToString();

                return (CreateString(n1, n2, ans, '-'));
            }
            //Rephrase the code above 

            /*solution = ans.ToString();
            string n1 = num1.ToString();
            string n2 = num2.ToString();

            //Solution to type
            answerType.GetComponent<Text>().text = "Type the number: " + solution;


            return (CreateString(n1, n2, ans, '-'));*/
        }


    }

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

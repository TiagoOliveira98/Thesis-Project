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

    //public int numberEquations;


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

        //numberEquations = 0;

        EquationVector();
    }


    // Update is called once per frame
    void Update()
    {
        //GameObject.Find("Confirmation").gameObject.GetComponent<Confirmation>().solution = solution;
        //GameObject.Find("Confirmation").gameObject.GetComponent<Confirmation>().initial = initial;
        if(correct == true )
        {
            if (i == 20)
                UnityEditor.EditorApplication.isPlaying = false;
                //Application.Quit();

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
        aux[0] = "8 + 9 = 20";
        aux[1] = "1 + 9 = 11";
        aux[2] = "6 + 0 = 8";
        aux[3] = "2 + 5 = 7";
        aux[4] = "9 + 9 = 18";
        aux[5] = "1 + 9 = 10";
        aux[6] = "9 + 4 = 13";
        aux[7] = "8 + 1 = 9";
        aux[8] = "4 + 9 = 10";
        aux[9] = "7 + 9 = 16";
        aux[10] = "6 + 0 = 6";
        aux[11] = "8 + 9 = 17";
        aux[12] = "6 + 7 = 16";
        aux[13] = "7 + 3 = 11";
        aux[14] = "6 + 1 = 6";
        aux[15] = "7 + 0 = 7";
        aux[16] = "2 + 0 = 2";
        aux[17] = "0 + 8 = 5";
        aux[18] = "6 + 3 = 14";
        aux[19] = "9 + 0 = 7";

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

        auxCheck[0] = 0;
        auxCheck[1] = 0;
        auxCheck[2] = 0;
        auxCheck[3] = 1;
        auxCheck[4] = 1;
        auxCheck[5] = 1;
        auxCheck[6] = 1;
        auxCheck[7] = 1;
        auxCheck[8] = 0;
        auxCheck[9] = 1;
        auxCheck[10] = 1;
        auxCheck[11] = 1;
        auxCheck[12] = 0;
        auxCheck[13] = 0;
        auxCheck[14] = 0;
        auxCheck[15] = 1;
        auxCheck[16] = 1;
        auxCheck[17] = 0;
        auxCheck[18] = 0;
        auxCheck[19] = 0;

    }

    string GenerateEquationNew()
    {
        check = auxCheck[i];
        i += 1;
        return aux[i - 1];
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

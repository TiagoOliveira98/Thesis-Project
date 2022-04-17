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

    public bool even;

    public int i;

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
            initial = GenerateEquationNew();
            screen.GetComponent<TextMesh>().text = initial;
            correct = false;

            GameObject.Find("StroopTest").GetComponent<Stroop>().change = 0;
            GameObject.Find("StroopTest").GetComponent<Stroop>().time = 0f;
        }
    }

    void EquationVector()
    {
        aux[0] = "8 + 9 + 1 + 9 = 20";
        aux[1] = "6 + 0 + 2 + 5 = 21";
        aux[2] = "9 + 9 + 1 + 9 = 18";
        aux[3] = "9 + 4 + 8 + 1 = 22";
        aux[4] = "4 + 9 + 7 + 9 = 31";
        aux[5] = "6 + 0 + 8 + 9 = 23";
        aux[6] = "6 + 7 + 7 + 3 = 17";
        aux[7] = "6 + 1 + 7 + 0 = 14";
        aux[8] = "2 + 0 + 0 + 8 = 10";
        aux[9] = "6 + 3 + 9 + 0 = 15";
        aux[10] = "4 + 3 + 7 + 7 = 22";
        aux[11] = "1 + 4 + 4 + 6 = 15";
        aux[12] = "7 + 7 + 2 + 6 = 25";
        aux[13] = "6 + 1 + 1 + 4 = 12";
        aux[14] = "9 + 3 + 5 + 2 = 13";
        aux[15] = "7 + 2 + 5 + 6 = 20";
        aux[16] = "8 + 9 + 5 + 1 = 9";
        aux[17] = "1 + 2 + 9 + 3 = 19";
        aux[18] = "8 + 2 + 9 + 3 = 22";
        aux[19] = "1 + 2 + 6 + 4 = 13";

        auxEven[0] = false;
        auxEven[1] = false;
        auxEven[2] = true;
        auxEven[3] = true;
        auxEven[4] = false;
        auxEven[5] = false;
        auxEven[6] = false;
        auxEven[7] = true;
        auxEven[8] = true;
        auxEven[9] = true;
        auxEven[10] = false;
        auxEven[11] = false;
        auxEven[12] = true;
        auxEven[13] = true;
        auxEven[14] = false;
        auxEven[15] = true;
        auxEven[16] = false;
        auxEven[17] = false;
        auxEven[18] = true;
        auxEven[19] = false;

        auxCheck[0] = 0;
        auxCheck[1] = 0;
        auxCheck[2] = 0;
        auxCheck[3] = 1;
        auxCheck[4] = 0;
        auxCheck[5] = 1;
        auxCheck[6] = 0;
        auxCheck[7] = 1;
        auxCheck[8] = 1;
        auxCheck[9] = 0;
        auxCheck[10] = 0;
        auxCheck[11] = 1;
        auxCheck[12] = 0;
        auxCheck[13] = 1;
        auxCheck[14] = 0;
        auxCheck[15] = 1;
        auxCheck[16] = 0;
        auxCheck[17] = 0;
        auxCheck[18] = 1;
        auxCheck[19] = 1;

    }

    string GenerateEquationNew()
    {
        even = auxEven[i];
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
            /*
            num1 = Random.Range(0, 10);
            num2 = Random.Range(0, 10);

            ans = num1 * num2;
            */
            int ansAux;
            num1 = Random.Range(0, 5);
            num2 = Random.Range(0, 5);

            ans = num1 * num2;
            /**solution = ans.ToString();

            return (CreateString(num1.ToString(), num2.ToString(), ans, 'x'));**/

            if (ans % 2 == 0 || ans == 0)
            {
                even = true;
            }
            else
                even = false;

            check = Random.Range(0, 2);
            if (check == 0)
            {
                //Create a wrong answer
                ansAux = ans + Random.Range(-5, 6);
                while (ansAux < 0)
                {
                    ansAux = ans + Random.Range(-5, 6);
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
            /*
            num1 = Random.Range(0, 40);
            num2 = Random.Range(0, 40);

            ans = num1 + num2;
            */
            int ansAux;
            num1 = Random.Range(0, 11);
            num2 = Random.Range(0, 11);
            ans = num1 + num2;
            /**solution = ans.ToString();

            return (CreateString(num1.ToString(), num2.ToString(), ans, '+'));**/

            if (ans % 2 == 0 || ans == 0)
            {
                even = true;
            }
            else
                even = false;

            check = Random.Range(0, 2);
            if (check == 0)
            {
                //Create a wrong answer
                ansAux = ans + Random.Range(-5, 6);
                while (ansAux < 0 || ansAux == ans)
                {
                    ansAux = ans + Random.Range(-5, 6);
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
        }
        else
        {
            int ansAux;
            int aux = Random.Range(0, 11);
            int aux2 = Random.Range(0, 11);
            //num1 = Random.Range(0, 40);
            //num2 = Random.Range(0, 40);

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

            if (ans % 2 == 0 || ans == 0)
            {
                even = true;
            }
            else
                even = false;


            check = Random.Range(0,2);
            if(check == 0)
            {
                //Create a wrong answer
                ansAux = ans + Random.Range(-5 , 6);
                while(ansAux < 0 )
                {
                    ansAux = ans + Random.Range(-5 , 6);
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
            
            /*int aux = Random.Range(0, 40);
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
            solution = ans.ToString();
            string n1 = num1.ToString();
            string n2 = num2.ToString();

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

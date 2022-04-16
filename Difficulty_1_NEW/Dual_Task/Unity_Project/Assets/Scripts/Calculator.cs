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
        aux[0] = "5 + 2 + 7 = 16";
        aux[1] = "1 + 6 + 1 = 9";
        aux[2] = "3 + 6 + 7 = 16";
        aux[3] = "0 + 9 + 7 = 16";
        aux[4] = "4 + 4 + 4 = 12";
        aux[5] = "3 + 5 + 5 = 13";
        aux[6] = "8 + 7 + 6 = 21";
        aux[7] = "3 + 8 + 5 = 16";
        aux[8] = "3 + 9 + 8 = 20";
        aux[9] = "5 + 6 + 5 = 13";
        aux[10] = "2 + 3 + 4 = 10";
        aux[11] = "2 + 8 + 1 = 11";
        aux[12] = "2 + 1 + 2 = 5";
        aux[13] = "4 + 3 + 9 = 13";
        aux[14] = "4 + 1 + 9 = 18";
        aux[15] = "9 + 4 + 1 = 14";
        aux[16] = "2 + 4 + 5 = 9";
        aux[17] = "2 + 6 + 7 = 12";
        aux[18] = "2 + 1 + 2 = 5";
        aux[19] = "3 + 4 + 5 = 19";


        auxEven[0] = true;
        auxEven[1] = true;
        auxEven[2] = false;
        auxEven[3] = true;
        auxEven[4] = true;
        auxEven[5] = false;
        auxEven[6] = false;
        auxEven[7] = true;
        auxEven[8] = true;
        auxEven[9] = true;
        auxEven[10] = false;
        auxEven[11] = false;
        auxEven[12] = false;
        auxEven[13] = true;
        auxEven[14] = true;
        auxEven[15] = true;
        auxEven[16] = false;
        auxEven[17] = false;
        auxEven[18] = false;
        auxEven[19] = true;

        auxCheck[0] = 0;
        auxCheck[1] = 0;
        auxCheck[2] = 1;
        auxCheck[3] = 1;
        auxCheck[4] = 1;
        auxCheck[5] = 1;
        auxCheck[6] = 1;
        auxCheck[7] = 1;
        auxCheck[8] = 1;
        auxCheck[9] = 0;
        auxCheck[10] = 0;
        auxCheck[11] = 1;
        auxCheck[12] = 1;
        auxCheck[13] = 0;
        auxCheck[14] = 0;
        auxCheck[15] = 1;
        auxCheck[16] = 0;
        auxCheck[17] = 0;
        auxCheck[18] = 1;
        auxCheck[19] = 0;

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

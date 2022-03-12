using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectNumber : MonoBehaviour
{
    public GameObject screen;

    public GameObject enter;

    int index;

    string answer, str;

    bool[] pushDown;

    // Start is called before the first frame update
    void Start()
    {
        pushDown = new bool[10];
        
        for(int i = 0; i <10; i++)
        {
            pushDown[i] = true;
        }
    }

    


    void PushButton(int n)
    {
        index = screen.GetComponent<TextMesh>().text.IndexOf("_");

        //if (index != -1)
        //{
        //    screen.GetComponent<TextMesh>().text = screen.GetComponent<TextMesh>().text.Substring(0, index) + n.ToString() + screen.GetComponent<TextMesh>().text.Substring(index + 1);
        //}

        if (index != -1)
        {
            screen.GetComponent<TextMesh>().text = screen.GetComponent<TextMesh>().text.Substring(0, index) + n.ToString() + screen.GetComponent<TextMesh>().text.Substring(index + 1);
            //answer += name; 
            //str += name;
            //Debug.Log("STR: " + str);
            //GameObject.Find("Confirmation").gameObject.GetComponent<Confirmation>().answer = str;
            //Debug.Log(GameObject.Find("Confirmation").gameObject.GetComponent<Confirmation>().answer);
            str = Confirmation.answer;
            Debug.Log("STR: " + str);
            answer = str + n;
            Debug.Log("ANSWER: " + answer);
            Confirmation.answer = answer;

            //Block double click
            //GetComponent<Rigidbody>().detectCollisions = false;
            ////////GetComponent<Collider>().enabled = false;

            //Allow confirmations
            enter.GetComponent<Confirmation>().canConfirm = true;
            //Confirmation.canConfirm = true;

            //commented
            //StartCoroutine("waiter");
            startIn(n);


        }
    }

    public void ResetIn0()
    {
        //Vector3 v = transform.position;

        //v.y = 0f;
        GameObject aux = GameObject.Find("0");
        aux.transform.localPosition = new Vector3(aux.transform.localPosition.x, 0f, aux.transform.localPosition.z);
        pushDown[0] = true;
    }

    public void ResetIn1()
    {
        //Vector3 v = transform.position;

        //v.y = 0f;
        GameObject aux = GameObject.Find("1");
        aux.transform.localPosition = new Vector3(aux.transform.localPosition.x, 0f, aux.transform.localPosition.z);
        pushDown[1] = true;
    }
    public void ResetIn2()
    {
        //Vector3 v = transform.position;

        //v.y = 0f;
        GameObject aux = GameObject.Find("2");
        aux.transform.localPosition = new Vector3(aux.transform.localPosition.x, 0f, aux.transform.localPosition.z);
        pushDown[2] = true;
    }
    public void ResetIn3()
    {
        //Vector3 v = transform.position;

        //v.y = 0f;
        GameObject aux = GameObject.Find("3");
        aux.transform.localPosition = new Vector3(aux.transform.localPosition.x, 0f, aux.transform.localPosition.z);
        pushDown[3] = true;
    }
    public void ResetIn4()
    {
        //Vector3 v = transform.position;

        //v.y = 0f;
        GameObject aux = GameObject.Find("4");
        aux.transform.localPosition = new Vector3(aux.transform.localPosition.x, 0f, aux.transform.localPosition.z);
        pushDown[4] = true;
    }
    public void ResetIn5()
    {
        //Vector3 v = transform.position;

        //v.y = 0f;
        GameObject aux = GameObject.Find("5");
        aux.transform.localPosition = new Vector3(aux.transform.localPosition.x, 0f, aux.transform.localPosition.z);
        pushDown[5] = true;
    }
    public void ResetIn6()
    {
        //Vector3 v = transform.position;

        //v.y = 0f;
        GameObject aux = GameObject.Find("6");
        aux.transform.localPosition = new Vector3(aux.transform.localPosition.x, 0f, aux.transform.localPosition.z);
        pushDown[6] = true;
    }
    public void ResetIn7()
    {
        //Vector3 v = transform.position;

        //v.y = 0f;
        GameObject aux = GameObject.Find("7");
        aux.transform.localPosition = new Vector3(aux.transform.localPosition.x, 0f, aux.transform.localPosition.z);
        pushDown[7] = true;
    }
    public void ResetIn8()
    {
        //Vector3 v = transform.position;

        //v.y = 0f;
        GameObject aux = GameObject.Find("8");
        aux.transform.localPosition = new Vector3(aux.transform.localPosition.x, 0f, aux.transform.localPosition.z);
        pushDown[8] = true;
    }

    public void ResetIn9(int n)
    {
        //Vector3 v = transform.position;

        //v.y = 0f;
        GameObject aux = GameObject.Find("9");
        aux.transform.localPosition = new Vector3(transform.localPosition.x, 0f, transform.localPosition.z);
        pushDown[9] = true;
    }

    public void startIn(int n)
    {
        //StartCoroutine("waiter");
        pushDown[n] = false;

        //Vector3 v = transform.position;
        //v.y = -0.2f;
        //transform.position = new Vector3(transform.position.x, -0.2f, transform.position.z);
        GameObject aux = GameObject.Find(n.ToString());
        aux.transform.localPosition = new Vector3(aux.transform.localPosition.x, -0.2f, aux.transform.localPosition.z);

        string s = "ResetIn" + n.ToString();
        Invoke(s, 3);
        //yield return new WaitForSecondsRealtime(5);

        //v.y = 0f;
        //GetComponent<Collider>().enabled = true;
    }

    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad0) == true)
        {
            PushButton(0);
        }
        if (Input.GetKeyDown(KeyCode.Keypad1) == true)
        {
            PushButton(1);
        }
        if (Input.GetKeyDown(KeyCode.Keypad2) == true)
        {
            PushButton(2);
        }
        if (Input.GetKeyDown(KeyCode.Keypad3) == true)
        {
            PushButton(3);
        }
        if (Input.GetKeyDown(KeyCode.Keypad4) == true)
        {
            PushButton(4);
        }
        if (Input.GetKeyDown(KeyCode.Keypad5) == true)
        {
            PushButton(5);
        }
        if (Input.GetKeyDown(KeyCode.Keypad6) == true)
        {
            PushButton(6);
        }
        if (Input.GetKeyDown(KeyCode.Keypad7) == true)
        {
            PushButton(7);
        }
        if (Input.GetKeyDown(KeyCode.Keypad8) == true)
        {
            PushButton(8);
        }
        if (Input.GetKeyDown(KeyCode.Keypad9) == true)
        {
            PushButton(9);
        }
        
        
    }
}

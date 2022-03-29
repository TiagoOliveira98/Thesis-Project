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

    // Start is called before the first frame update
    void Start()
    {
        cameras = GameObject.Find("Main Camera");
        points = cameras.GetComponent<Points>();

        pushDown = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (/*Input.GetKeyDown(KeyCode.Return)*/Input.GetKeyDown(KeyCode.RightArrow) == true)
        {
            PushButton();
        }
    }

    public void ResetIn()
    {
        //Vector3 v = transform.position;

        //v.y = 0f;
        GameObject aux = GameObject.Find("Enter");
        aux.transform.localPosition = new Vector3(aux.transform.localPosition.x, 0f, aux.transform.localPosition.z);
        pushDown = true;
    }

    public void StartIn()
    {
        pushDown = false;
        GameObject aux = GameObject.Find("Enter");

        aux.transform.localPosition = new Vector3(aux.transform.localPosition.x, -0.2f, aux.transform.localPosition.z);

        Invoke("ResetIn", 1);
    }

    public void PushButton()
    {
        //Get the solution to the problem created in teh Calculator object script
        solution = GameObject.Find("Calculator").gameObject.GetComponent<Calculator>().solution;

        StartIn();

        //Case if the answer and solution are the same
        if (Confirmation.answer == GameObject.Find("Calculator").gameObject.GetComponent<Calculator>().solution)
        {
            GameObject.Find("Calculator").gameObject.GetComponent<Calculator>().correct = true;
            points.point += 1;

            //Debug.Log(answer);
            //Reset the answer
            Confirmation.answer = "";
            //screen.GetComponent<TextMesh>().text = "Correct";
            //Render another operation

            //Give a Point or somethig similar/ Progress bar
            //correct = true;

            //Text.GetComponent<Text>().text = latest;

        }
        else
        {
            screen.GetComponent<TextMesh>().text = GameObject.Find("Calculator").gameObject.GetComponent<Calculator>().initial;
            //Debug.Log(answer);
            //Debug.Log(solution);
            //////////////Text aux = lives.GetComponent<Text>();
            //////////////size = aux.text.Length;

            //Reset the answer
            Confirmation.answer = "";
            //NEW
            points.point = 0;
            //Render the same operation
            //Maybe set a group of 3 hearts and take one of them out for each wrong answer

        }
        //Disable confirmations after entering aan answer
        //canConfirm = false;
    }
}

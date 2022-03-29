using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteCog : MonoBehaviour
{
    public bool pushDown;

    public GameObject screen;

    // Start is called before the first frame update
    void Start()
    {
        pushDown = true;
    }

    public void StartIn()
    {
        pushDown = false;

        //Vector3 v = transform.position;
        //v.y = -0.2f;
        //transform.position = new Vector3(transform.position.x, -0.2f, transform.position.z);
        GameObject aux = GameObject.Find("Clear(CE)");

        aux.transform.localPosition = new Vector3(aux.transform.localPosition.x, -0.2f, aux.transform.localPosition.z);


        Invoke("ResetIn", 1);
        //yield return new WaitForSecondsRealtime(5);

        //v.y = 0f;
        //GetComponent<Collider>().enabled = true;
    }

    public void ResetIn()
    {
        //Vector3 v = transform.position;

        //v.y = 0f;
        GameObject aux = GameObject.Find("Clear(CE)");
        aux.transform.localPosition = new Vector3(aux.transform.localPosition.x, 0f, aux.transform.localPosition.z);
        pushDown = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(/*KeyCode.Delete*/KeyCode.LeftArrow) == true)
        {
            //PushButton();
            StartIn();

            //string a = GameObject.Find("Confirmation").gameObject.GetComponent<Confirmation>().initial;
            screen.GetComponent<TextMesh>().text = GameObject.Find("Calculator").gameObject.GetComponent<Calculator>().initial;
            //Debug.Log(a);
            //screen.GetComponent<TextMesh>().text = Confirmation.initial;
            Confirmation.answer = "";
        }
    }
}

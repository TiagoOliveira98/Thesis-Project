using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Globalization;
using System;

public class ColorButtons : MonoBehaviour
{
    public long sol;
    public int sol1;

    public int n1, n2;

    public string s1, s2;

    public Material myMaterial1, myMaterial2;

    float time;

    // Start is called before the first frame update
    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time > 1)
        {
            string s = GameObject.Find("Calculator").GetComponent<Calculator>().solution;
            if(s != null )
                Debug.Log(s);

            //sol = Int64.ParseInt64.Parse(s);
            if (s != null)
            {
                int.TryParse(s, out sol1);

                n1 = ((int)sol1) / 10;
                n2 = ((int)sol1) % 10;

                if (n1 != 0)
                {
                    s1 = "Materials/" + n1.ToString() + "_y";

                    myMaterial1 = Resources.Load<Material>(s1);//Resources.Load(s1, typeof(Material)) as Material;

                    GameObject.Find(n1.ToString()).transform.GetChild(0).GetComponent<MeshRenderer>().material = myMaterial1;
                }

                s2 = "Materials/" + n2.ToString() + "_y";

                myMaterial2 = Resources.Load<Material>(s2);//, //typeof(Material));// as Material;

                GameObject.Find(n2.ToString()).transform.GetChild(0).GetComponent<MeshRenderer>().material = myMaterial2;
            }
            
        }

        //string s = GameObject.Find("Calculator").GetComponent<Calculator>().solution;
        //if(s != null || s != "" )
        //    Debug.Log(s);

        ////sol = Int64.ParseInt64.Parse(s);
        //if (s != null)
        //{
        //    int.TryParse(s, out sol1);
        //
        //    n1 = ((int)sol1) / 10;
        //    n2 = ((int)sol1) % 10;
        //
        //    if (n1 != 0)
        //    {
        //        s1 = "Materials/" + n1.ToString() + "_y";
        //
        //        myMaterial1 = Resources.Load<Material>(s1);//Resources.Load(s1, typeof(Material)) as Material;
        //
        //        GameObject.Find(n1.ToString()).transform.GetChild(0).GetComponent<MeshRenderer>().material = myMaterial1;
        //    }
        //
        //    s2 = "Materials/" + n2.ToString() + "_y";
        //
        //    myMaterial2 = Resources.Load<Material>(s2);//, //typeof(Material));// as Material;
        //
        //    GameObject.Find(n2.ToString()).transform.GetChild(0).GetComponent<MeshRenderer>().material = myMaterial2;
        //}

    }
}

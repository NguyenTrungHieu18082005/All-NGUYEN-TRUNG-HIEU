using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parse_Convert : MonoBehaviour
{
    [SerializeField] private string strNum1;
    [SerializeField] private int num;

    [SerializeField] private string strNum2;
    [SerializeField] private float floatNum;

    // Start is called before the first frame update
    void Start()
    {
        strNum1 = "123";
        num = int.Parse(strNum1);
        Debug.Log("Parse Number: " + num);

        strNum2 = "124.67";
        floatNum = Convert.ToSingle(strNum2);
        Debug.Log("Converted Float Number: " + floatNum);

    }

    // Update is called once per frame
    void Update()
    {

    }
}

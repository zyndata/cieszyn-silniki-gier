using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleScript : MonoBehaviour
{
    int number = 1; //liczby ca³kowite
    float floatNumber = 2.345f; //liczby zmiennoprzecinkowe

    //teksty
    string text = "this is a text";

    //pola logiczne
    bool logical = true;  //false

    //array

    int[] intArray; //tablice
    int[] intArray2 = new int[] { 1, 2, 3, 4 };
    int[] intArray3 = { 1, 2, 3, 4 };

    List<int> list = new List<int>(); //lista



    private int MyMethod()
    {
        return number;
    }

    private void Awake()
    {
        Debug.Log("Awake");
    }

    void Start()
    {
        Debug.Log("Start" + MyMethod());
    }

    // Update is called once per frame
    void Update()
    {

    }
}

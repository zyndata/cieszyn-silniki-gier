using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleScript : MonoBehaviour
{
    //SerializeField field ustawia prywatne pole widoczne w inspektorze
    //HideInInspector ukrywa publiczne pola w inspektorze

    //liczby
    [SerializeField] private int number = 1; //liczby ca³kowite
    [HideInInspector] public float floatNumber = 2.345f; //liczby zmiennoprzecinkowe

    //teksty
    string text = "this is a text"; //string to tablica znaków

    //pola logiczne
    bool logical = true;  //false

    //array
    int[] intArray; //tablice
    int[] intArray2 = new int[] { 1, 2, 3, 4 };
    int[] intArray3 = { 1, 2, 3, 4 };

    [SerializeField] private List<int> list1 = new List<int>(); //lista
    [SerializeField] private List<MyClass> list2 = new List<MyClass>(); //lista z klas¹

    //vector
    public Vector3 vector3 = new Vector3(1, 2, 3);
    public Vector2 vector2 = new Vector2(1, 2);


    public MyClass sampleClass = new MyClass();



    private void Awake()
    {
        Debug.Log("Awake");
    }


    void Start()
    {
        sampleClass.SetHp(99);
        Debug.Log("Start " + GetTextLength("sadasdasduhaskduh"));
    }

    // Update is called once per frame
    void Update()
    {

    }

    // == sprawdzenie równoœci

    void IfEqualFunction()
    {
        if (number == 1)
        {
            //
        }
    }

    void IfNotFunction()
    {
        if (number != 1)
        {
            //
        }
    }


    [ContextMenu("Print HP")] //context menu pozwala wywo³aæ metode w inspektorze
    public void PrintPlayerHp()
    {
        Debug.Log("Player hp: " + number);
    }

    private int GetTextLength(string text)
    {
        return text.Length;
    }

}

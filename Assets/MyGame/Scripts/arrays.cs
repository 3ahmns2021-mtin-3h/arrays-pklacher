using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrays : MonoBehaviour
{
    int[] myIntArray = { 23, 34, 45 };
    string[] myStringArray = { "One", "Two", "Three" };
    float[] myFloatArray = { 1.234f, 2.345f, 3.456f };
    bool[] myBoolArray = { false, true, false };

    int myIntOne = 23;
    int myIntTwo = 34;
    int myIntThree = 45;

    string myStringOne = "One";
    string myStringTwo = "Two";
    string myStringThree = "Three";

    bool myBoolOne = false;
    bool myBoolTwo = true;
    bool myBoolThree = false;


    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < myStringArray.Length; i++)
        {
            Debug.Log(myStringArray[i]);
        }

        Debug.Log(myStringOne);
        Debug.Log(myStringTwo);
        Debug.Log(myStringThree);

        for(int i = 0; i < myIntArray.Length; i++)
        {
            Debug.Log(myIntArray[i]);
        }

        Debug.Log(myIntOne);
        Debug.Log(myIntTwo);
        Debug.Log(myIntThree);

        for (int i = 0; i < myBoolArray.Length; i++)
        {
            Debug.Log(myBoolArray[i]);
        }

        Debug.Log(myBoolOne);
        Debug.Log(myBoolTwo);
        Debug.Log(myBoolThree);

        for (int i = 0; i < myFloatArray.Length; i++)
        {
            Debug.Log(myFloatArray[i]);
        }
    }
}

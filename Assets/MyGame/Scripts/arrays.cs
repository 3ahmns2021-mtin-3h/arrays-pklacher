using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrays : MonoBehaviour
{
    int[] myIntArray = { 23, 34, 45 };
    string[] myStringArray = { "Number One", "Number Two", "Number Three" };
    float[] myFloatArray = { 1.234f, 2.345f, 3.456f };
    bool[] myBoolArray = { false, true, false };

    int myIntArrayOne = 23;
    int myIntArrayTwo = 34;
    int myIntArrayThree = 45;

    bool myBoolOne = false;
    bool myBoolTwo = true;
    bool myBoolThree = false;

    public GameObject square;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(myStringArray);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}

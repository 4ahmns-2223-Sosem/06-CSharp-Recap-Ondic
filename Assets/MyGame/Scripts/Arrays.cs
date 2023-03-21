using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{

    string[] colorArray = new string[5];

    void Start()
    {
        for (int i = 0; i < colorArray.Length; i++)
        {
            if (i == 1)
            {
                colorArray[i] = "BOOM";
                Debug.Log(colorArray[i] + " - " + "BOOM");
            }
            else if(i == 3)
            {
                colorArray[i] = "KACHOW";
                Debug.Log(colorArray[i] + " - " + "KACHOW");
            }
            else
            {
                colorArray[i] = "POW";
                Debug.Log(colorArray[i] + " - " + "POW");
            }
        }



        
    }
}

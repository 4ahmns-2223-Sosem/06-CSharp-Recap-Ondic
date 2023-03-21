using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForSchleife : MonoBehaviour
{
    private int loopLimit;
    // Start is called before the first frame update
    void Start()
    {
        loopLimit = 8;

        for(int i = 1; i<=loopLimit;i++)
        {
            //8 Loops
            Debug.Log(i);
        }

        if (loopLimit == 8)
        {
            Debug.Log("Loop done");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

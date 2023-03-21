using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfAndElse : MonoBehaviour
{
    private int limit;

    private float Var1;
    private float Var2;
    private float Var3;
    // Start is called before the first frame update
    void Start()
    {
        limit = Random.Range(1, 7);
        Debug.Log(limit);

        if (limit == 1)
        {
            Debug.Log("First");
        }
        else if (limit == 6)
        {
            Debug.Log("Last");
        }
        else
        {
            Debug.Log("Inbetween");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

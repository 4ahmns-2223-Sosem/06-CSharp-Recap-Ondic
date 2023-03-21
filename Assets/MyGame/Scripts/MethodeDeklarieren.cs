using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodeDeklarieren : MonoBehaviour
{
    public bool gumbodiaGung;
    private int counterGung;
    // Start is called before the first frame update
    void Start()
    {
        counterGung = Random.Range(0, 3);
        Debug.Log(counterGung);

        if (counterGung == 0)
        {
            BoolTrue();
        }
        else if (counterGung == 1)
        {
            BoolFalse();
        }
        else
        {
            BoolNeutral();
        }
    }

    void BoolTrue()
    {
        gumbodiaGung = true;
        Debug.Log("SET TO TRUE");
    }
    void BoolFalse()
    {
        gumbodiaGung = false;
        Debug.Log("SET TO FALSE");

    }
    void BoolNeutral()
    {
        Debug.Log("NOTHING HAPPENS");
    }

}

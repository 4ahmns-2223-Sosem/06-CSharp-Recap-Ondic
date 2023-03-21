using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableDeklarieren : MonoBehaviour
{
    private float gleitZahl;
    private int ganzZahl;
    private string text;
    private bool boolean;
    private GameObject objekt;
    // Start is called before the first frame update
    void Start()
    {
        gleitZahl = 8.4724f;
            Debug.Log(gleitZahl + " - " + "GLEITZAHL");
        ganzZahl = 14;
            Debug.Log(ganzZahl + " - " + "GANZZAHL");
        text = "Cumbotcha";
            Debug.Log(text + " - " + "TEXT");
        boolean = true;
            Debug.Log(boolean + " - " + "BOOL");

        objekt = FindObjectOfType<GameObject>();

        if (objekt.name == "Variable dummy")
        {
            Debug.Log("OBJEKT ZUGEWIESEN" + " - " + "GAMEOBJECT");
        }
    }



}

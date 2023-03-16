using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum State
{
    Done,
    WIP,
    Cancel,
}
public class MyEnums : MonoBehaviour
{
    //Deklaration
    State myState;

    // Start is called before the first frame update
    void Start()
    {
        myState = State.Done;

        switch (myState)
        {
            case State.Done: 
                Debug.Log(State.Done + " " + (int)State.Done); 
                break;
            case State.WIP:
                Debug.Log(State.WIP + " " + (int)State.WIP);
                break;
            case State.Cancel:
                Debug.Log(State.Cancel + " " + (int)State.Cancel);
                break;
        }

        if (myState == State.Done)
        {
            Debug.Log(State.Done + " " + (int)State.Done);
        }
        else if (myState == State.WIP)
        {
            Debug.Log(State.WIP + " " + (int)State.WIP);
        }
        else
        {
            Debug.Log(State.Cancel + " " + (int)State.Cancel);
        }

        //Beides das gleiche
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
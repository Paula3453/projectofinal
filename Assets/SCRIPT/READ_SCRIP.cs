 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class READ_SCRIP : MonoBehaviour
{
    private string input;
    // Start is called before the first frame update
    public void ReadInput (string write)
    {
        input = write;
        Debug.Log(input);
    }

}

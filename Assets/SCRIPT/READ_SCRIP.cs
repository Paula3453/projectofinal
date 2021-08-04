 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class READ_SCRIP : MonoBehaviour
{
    private string input;
    // Start is called before the first frame update
    public void ReadInput (InputField write)
    {
        write.text = input;
        Debug.Log(input);
    }

}

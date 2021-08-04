using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CLUB_SELCETION : MonoBehaviour
{
    public string input;
    // Start is called before the first frame update
    public void CLUB(Text write)
    {
        write.text = input;
        Debug.Log(input);
    }
}

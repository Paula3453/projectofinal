using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class READ_SCRIPT : MonoBehaviour
{   
    public string input;
    public Sprite inputclub;

    public GameObject Canvas;
    public GameObject Canvas2;

    public Text name;
    public Sprite club; 
    // Start is called before the first frame update
    public void READ(Text write)
    {
        input = write.text;
        PlayerPrefs.SetString("NombreJugador", input);
        Debug.Log(input);
    }
    public void CLUB(Image image)
    {
        inputclub = image.sprite;
        Debug.Log(inputclub);
        Canvas.SetActive(false);
    }
    public void CanvasCLub()
    {
        Canvas2.SetActive(true);
        name.text = input;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class READ_SCRIPT : MonoBehaviour
{   
    public string textSaved;
    public Sprite clubImageSaved;
    public string clubNameSaved;
    
    public GameObject Canvas;
    public GameObject Canvas2;

    public Text _name;
    public Image club;
    public GameObject Escudos;
    // Start is called before the first frame update
    public void READ(Text write)
    {
        textSaved = write.text;
        PlayerPrefs.SetString("NombreJugador", textSaved);
        Debug.Log(textSaved);
        Escudos.SetActive(true);
    }
    public void CLUB(Image image)
    {
        clubImageSaved = image.sprite;
        Debug.Log(clubImageSaved);
        
        club.sprite = clubImageSaved;
        _name.text = textSaved;
        clubNameSaved = clubImageSaved.name;
    }

    public void ClubNameSaved(string clubName)
    {
        clubNameSaved = clubName;
    }
    public void CanvasCLub()
    {
        Canvas2.SetActive(true);
        _name.text = textSaved;
    }
}

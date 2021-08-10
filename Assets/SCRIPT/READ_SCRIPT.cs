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

    public CARD[] Real_Madrid;
    public CARD[] Arsenal;
    public CARD[] Tottenham;
    public CARD[] Chelsea;
    public CARD[] Atletico_de_Madrid;
    public CARD[] Juventus;
    public CARD[] Milan;
    public CARD[] Manchester_City;
    public CARD[] Liverpool;
    public CARD[] Manchester_United;
    public CARD[] Barcelona;
    public CARD[] Inter_de_Milan;
    public CARD_DISPLAY[] cards;

    public Spawn_Balones PowerUps;
    public float UpShoot;
    public Text UpShootText;
    public float UpGRL;
    public Text UpGRLText;

    private void Start()
    {
        UpShoot = 0;
    }
    private void Update()
    {
        
    }
    public void PowerUp()
    {
        if (PowerUps.TiempoCD <= 0)
        {
            UpShoot += PowerUps.PwU_Shoot;
            UpShootText.text = "x " + UpShoot;
            UpGRL += PowerUps.PwU_GRL;
            UpGRLText.text = "x " + UpGRL;
        }
    }
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

        if (clubNameSaved == "Real_Madrid")
        {
            int i = 0;
            foreach (var item in cards)
            {
                item.ChangePlayer(Real_Madrid[i]);
                i++;
                Real_Madrid[0].Rating;
            }
        }
        if (clubNameSaved == "Arsenal")
        {
            int i = 0;
            foreach (var item in cards)
            {
                item.ChangePlayer(Arsenal[i]);
                i++;
            }
        }
        if (clubNameSaved == "Tottenham")
        {
            int i = 0;
            foreach (var item in cards)
            {
                item.ChangePlayer(Tottenham[i]);
                i++;
            }
        }
        if (clubNameSaved == "Chelsea")
        {
            int i = 0;
            foreach (var item in cards)
            {
                item.ChangePlayer(Chelsea[i]);
                i++;
            }
        }
        if (clubNameSaved == "Atletico_de_Madrid")
        {
            int i = 0;
            foreach (var item in cards)
            {
                item.ChangePlayer(Atletico_de_Madrid[i]);
                i++;
            }
        }
        if (clubNameSaved == "Juventus")
        {
            int i = 0;
            foreach (var item in cards)
            {
                item.ChangePlayer(Juventus[i]);
                i++;
            }
        }
        if (clubNameSaved == "Milan")
        {
            int i = 0;
            foreach (var item in cards)
            {
                item.ChangePlayer(Milan[i]);
                i++;
            }
        }
        if (clubNameSaved == "Manchester_City")
        {
            int i = 0;
            foreach (var item in cards)
            {
                item.ChangePlayer(Manchester_City[i]);
                i++;
            }
        }
        if (clubNameSaved == "Liverpool")
        {
            int i = 0;
            foreach (var item in cards)
            {
                item.ChangePlayer(Liverpool[i]);
                i++;
            }
        }
        if (clubNameSaved == "Manchester_United")
        {
            int i = 0;
            foreach (var item in cards)
            {
                item.ChangePlayer(Manchester_United[i]);
                i++;
            }
        }
        if (clubNameSaved == "Barcelona")
        {
            int i = 0;
            foreach (var item in cards)
            {
                item.ChangePlayer(Barcelona[i]);
                i++;
            }
        }
        if (clubNameSaved == "Inter_de_Milan")
        {
            int i = 0;
            foreach (var item in cards)
            {
                item.ChangePlayer(Inter_de_Milan[i]);
                i++;
            }
        }
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

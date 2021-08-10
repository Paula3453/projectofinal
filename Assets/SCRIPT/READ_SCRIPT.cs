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

    public CARD[] Real_Madrid; public float RatingRealMadrid;
    public CARD[] Arsenal; public float RatingArsenal;
    public CARD[] Tottenham; public float RatingTottenham;
    public CARD[] Chelsea; public float RatingChelsea;
    public CARD[] Atletico_de_Madrid; public float RatingAtleticoDeMadrid;
    public CARD[] Juventus; public float RatingJuventus;
    public CARD[] Milan; public float RatingMilan;
    public CARD[] Manchester_City; public float RatingManchesterCity;
    public CARD[] Liverpool; public float RatingLiverpool;
    public CARD[] Manchester_United; public float RatingManchesterUnited;
    public CARD[] Barcelona; public float RatingBarcelona;
    public CARD[] Inter_de_Milan; public float RatingInterDeMilan;
    public CARD_DISPLAY[] cards;

    public Spawn_Balones PowerUps;
    public float UpShoot;
    public Text UpShootText;
    public float UpGRL;
    public Text UpGRLText;

    public float count_days;
    public Text daystext;
    private void Start()
    {
        daystext.text = "DIA " + "" + count_days;
        UpShoot = 0;
        count_days = 0;
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
            }
            for (int RealMadrid = 0; RealMadrid <= 10; RealMadrid++)
            {
                RatingRealMadrid = RatingRealMadrid + Real_Madrid[RealMadrid].Rating;
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
            for (int Ars = 0; Ars <= 10; Ars++)
            {
                RatingArsenal = RatingArsenal + Arsenal[Ars].Rating;
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
            for (int Tot = 0; Tot <= 10; Tot++)
            {
                RatingTottenham = RatingTottenham + Tottenham[Tot].Rating;
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
            for (int Che = 0; Che <= 10; Che++)
            {
                RatingChelsea = RatingChelsea + Chelsea[Che].Rating;
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
            for (int Atl = 0; Atl <= 10; Atl++)
            {
                RatingAtleticoDeMadrid = RatingAtleticoDeMadrid + Atletico_de_Madrid[Atl].Rating;
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
            for (int Juv = 0; Juv <= 10; Juv++)
            {
                RatingJuventus = RatingJuventus + Juventus[Juv].Rating;
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
            for (int Mil = 0; Mil <= 10; Mil++)
            {
                RatingMilan = RatingMilan + Milan[Mil].Rating;
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
            for (int ManC = 0; ManC <= 10; ManC++)
            {
                RatingManchesterCity = RatingManchesterCity + Manchester_City[ManC].Rating;
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
            for (int Liv = 0; Liv <= 10; Liv++)
            {
                RatingLiverpool = RatingLiverpool + Liverpool[Liv].Rating;
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
            for (int ManU = 0; ManU <= 10; ManU++)
            {
                RatingManchesterUnited = RatingManchesterUnited + Manchester_United[ManU].Rating;
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
            for (int Bar = 0; Bar <= 10; Bar++)
            {
                RatingBarcelona = RatingBarcelona + Barcelona[Bar].Rating;
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
            for (int Int = 0; Int <= 10; Int++)
            {
                RatingInterDeMilan = RatingInterDeMilan + Inter_de_Milan[Int].Rating;
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
        daystext.text = "d�as "+ count_days;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Linq;

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
    public float RatingRealMadrid;
    public CARD[] Arsenal;
    public float RatingArsenal;
    public CARD[] Tottenham;
    public float RatingTottenham;
    public CARD[] Chelsea;
    public float RatingChelsea;
    public CARD[] Atletico_de_Madrid;
    public float RatingAtleticoDeMadrid;
    public CARD[] Juventus;
    public float RatingJuventus;
    public CARD[] Milan;
    public float RatingMilan;
    public CARD[] Manchester_City;
    public float RatingManchesterCity;
    public CARD[] Liverpool;
    public float RatingLiverpool;
    public CARD[] Manchester_United;
    public float RatingManchesterUnited;
    public CARD[] Barcelona;
    public float RatingBarcelona;
    public CARD[] Inter_de_Milan;
    public float RatingInterDeMilan;

    public CARD_DISPLAY[] cards;

    public Spawn_Balones PowerUps;
    public float UpShoot;
    public Text UpShootText;
    public float UpGRL;
    public Text UpGRLText;

    public float count_days;
    public Text daystext;

    public int resultado;
    public float PorcentajeLocal;
    public float RandomNum;
    public Text Ganador;

    public Text[] Resultados;
    public Text Jornada;

    public Text[] Clasificacion;
    public string[] Equipos;
    Dictionary<string, int> clasificacion = new Dictionary<string, int>();

    public string[] J1Local;
    public string[] J2Local;
    public string[] J3Local;
    public string[] J4Local;
    public string[] J5Local;
    public string[] J6Local;
    public string[] J7Local;
    public string[] J8Local;
    public string[] J9Local;
    public string[] J10Local;
    public string[] J11Local;
    string[][] Locales = new string[11][];
    public string[] J1Visitante;
    public string[] J2Visitante;
    public string[] J3Visitante;
    public string[] J4Visitante;
    public string[] J5Visitante;
    public string[] J6Visitante;
    public string[] J7Visitante;
    public string[] J8Visitante;
    public string[] J9Visitante;
    public string[] J10Visitante;
    public string[] J11Visitante;
    string[][] Visitantes = new string[11][];
    public List<Team> equipos = new List<Team>();


    private void Start()
    {
        Locales[0] = J1Local;
        Locales[1] = J2Local;
        Locales[2] = J3Local;
        Locales[3] = J4Local;
        Locales[4] = J5Local;
        Locales[5] = J6Local;
        Locales[6] = J7Local;
        Locales[7] = J8Local;
        Locales[8] = J9Local;
        Locales[9] = J10Local;
        Locales[10] = J11Local;

        Visitantes[0] = J1Visitante;
        Visitantes[1] = J2Visitante;
        Visitantes[2] = J3Visitante;
        Visitantes[3] = J4Visitante;
        Visitantes[4] = J5Visitante;
        Visitantes[5] = J6Visitante;
        Visitantes[6] = J7Visitante;
        Visitantes[7] = J8Visitante;
        Visitantes[8] = J9Visitante;
        Visitantes[9] = J10Visitante;
        Visitantes[10] = J11Visitante;

        //print(GetTeam("Tottenham").ratingTeam);
        daystext.text = "DIA " + "" + count_days;
        UpShoot = 0;
        count_days = 1;


    }
    private void Update()
    {

        //print(((100 / (RatingRealMadrid + RatingBarcelona)) * RatingRealMadrid));
        if (count_days % 2 == 0)
        {

            int jornada = (int)count_days / 2;
            jornada--;

            if (jornada >= 12)
            {
                jornada -= 12;
            }
            for (int i = 0; i < Locales[jornada].Length; i++)
            {
                RandomNum = Random.Range(0, 100);
                int Goles1 = Random.Range(1, 8);
                int Goles2 = Random.Range(0, Goles1);
                PorcentajeLocal = ((100 / (GetTeam(Locales[jornada][i]).ratingTeam + GetTeam(Visitantes[jornada][i]).ratingTeam)) * GetTeam(Locales[jornada][i]).ratingTeam);
                if (RandomNum <= PorcentajeLocal)
                {
                    if (clubNameSaved == GetTeam(Locales[jornada][i]).nombre)
                    {
                        Resultados[i].color = Color.green;
                        
                    }
                    else
                    {
                        Resultados[i].color = Color.white;
                    }
                    GetTeam(Locales[jornada][i]).puntos += 3;
                    clasificacion[GetTeam(Locales[jornada][i]).nombre] += 3;
                    Resultados[i].text = GetTeam(Locales[jornada][i]).nombre + "  " + Goles1 + " - " + Goles2 + "  " + GetTeam(Visitantes[jornada][i]).nombre;
                }
                else
                {
                    if (clubNameSaved == GetTeam(Visitantes[jornada][i]).nombre)
                    {
                        Resultados[i].color = Color.green;
                    }
                    else
                    {
                        Resultados[i].color = Color.white;
                    }
                    GetTeam(Visitantes[jornada][i]).puntos += 3;
                    clasificacion[GetTeam(Visitantes[jornada][i]).nombre] += 3;
                    Resultados[i].text = GetTeam(Locales[jornada][i]).nombre + "  " + Goles2 + " - " + Goles1 + "  " + GetTeam(Visitantes[jornada][i]).nombre;
                }
                Jornada.text = "JORNADA " + ((int)count_days / 2 );

            }
            count_days++;

            var myList = clasificacion.ToList();

            myList.Sort((pair1, pair2) => pair1.Value.CompareTo(pair2.Value));

            for (int Pos = 0; Pos < 12; Pos++)
            {
                if (myList[Pos].Key == clubNameSaved)
                {
                    Clasificacion[Pos].color = Color.green;
                }
                else
                {
                    Clasificacion[Pos].color = Color.white;
                }
                Clasificacion[Pos].text = (myList[Pos].Key + ": " + myList[Pos].Value);
            }
        }
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

        for (int RealMadrid = 0; RealMadrid <= 10; RealMadrid++)
        {
            RatingRealMadrid = RatingRealMadrid + Real_Madrid[RealMadrid].Rating;
        }
        for (int Ars = 0; Ars <= 10; Ars++)
        {
            RatingArsenal = RatingArsenal + Arsenal[Ars].Rating;
        }
        for (int Tot = 0; Tot <= 10; Tot++)
        {
            RatingTottenham = RatingTottenham + Tottenham[Tot].Rating;
        }
        for (int Che = 0; Che <= 10; Che++)
        {
            RatingChelsea = RatingChelsea + Chelsea[Che].Rating;
        }
        for (int Atl = 0; Atl <= 10; Atl++)
        {
            RatingAtleticoDeMadrid = RatingAtleticoDeMadrid + Atletico_de_Madrid[Atl].Rating;
        }
        for (int Juv = 0; Juv <= 10; Juv++)
        {
            RatingJuventus = RatingJuventus + Juventus[Juv].Rating;
        }
        for (int Mil = 0; Mil <= 10; Mil++)
        {
            RatingMilan = RatingMilan + Milan[Mil].Rating;
        }
        for (int ManC = 0; ManC <= 10; ManC++)
        {
            RatingManchesterCity = RatingManchesterCity + Manchester_City[ManC].Rating;
        }
        for (int Liv = 0; Liv <= 10; Liv++)
        {
            RatingLiverpool = RatingLiverpool + Liverpool[Liv].Rating;
        }
        for (int ManU = 0; ManU <= 10; ManU++)
        {
            RatingManchesterUnited = RatingManchesterUnited + Manchester_United[ManU].Rating;
        }
        for (int Bar = 0; Bar <= 10; Bar++)
        {
            RatingBarcelona = RatingBarcelona + Barcelona[Bar].Rating;
        }
        for (int Int = 0; Int <= 10; Int++)
        {
            RatingInterDeMilan = RatingInterDeMilan + Inter_de_Milan[Int].Rating;
        }
        if (clubNameSaved == "Real_Madrid")
        {
            int i = 0;
            foreach (var item in cards)
            {
                item.ChangePlayer(Real_Madrid[i]);
                i++;
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
        BuildTeamDatabase();
        foreach (var item in Equipos)
        {
            clasificacion.Add(GetTeam(item).nombre, GetTeam(item).puntos);
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
        daystext.text = "días " + count_days;
    }

    public Team GetTeam(string nombreEquipo)
    {
        return equipos.Find(team => team.nombre == nombreEquipo);
    }
    void BuildTeamDatabase()
    {
        equipos = new List<Team>()
        {
            new Team("Real Madrid", RatingRealMadrid, 0, 1),
            new Team("Tottenham", RatingTottenham, 0, 2),
            new Team("Arsenal", RatingArsenal, 0, 3),
            new Team("Atletico de Madrid", RatingAtleticoDeMadrid, 0, 4),
            new Team("FC Barcelona", RatingBarcelona, 0, 5),
            new Team("Inter de Milan", RatingInterDeMilan, 0, 6),
            new Team("Juventus", RatingJuventus, 0, 7),
            new Team("Liverpool", RatingLiverpool, 0, 8),
            new Team("Manchester City", RatingManchesterCity, 0,9),
            new Team("Manchester United", RatingManchesterUnited, 0, 10),
            new Team("Milan", RatingMilan, 0, 11),
            new Team("Chelsea", RatingChelsea, 0,12) ,
        };
    }
}

public class Team
{
    public string nombre;
    public float ratingTeam;
    public int puntos;
    public int posicion;

    public Team(string _nombre, float _ratingTeam, int _puntos, int _posicion)
    {
        nombre = _nombre;
        ratingTeam = _ratingTeam;
        puntos = _puntos;
        posicion = _posicion;
    }
    public Team(Team team)
    {
        this.nombre = team.nombre;
        this.ratingTeam = team.ratingTeam;
        this.puntos = team.puntos;
        this.posicion = team.posicion;
    }
}

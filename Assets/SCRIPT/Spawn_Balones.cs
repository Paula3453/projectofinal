using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Spawn_Balones : MonoBehaviour
{
    public GameObject Shoot;
    public int Balones;
    public Text BalonesText;
    public float speed;
    public int PwU_Shoot;
    public Text ShootText;
    public int PwU_GRL;
    public Text GRLText;
    public float InicioCD;
    public float MaxTiempoCD;
    public float TiempoCD;
    public Text TiempoText;

    public bool playing = true;
    public READ_SCRIPT read_script;

    public GameObject[] Spawn;
    float CurrentCD;
    public float MaxCD;
    public float x1;
    public float x0;
    public float y;

    public float speedPwUp;
    // Start is called before the first frame update
    void Start()
    {
        BalonesText.text = "x " + Balones;
        InicioCD = 2;
        TiempoCD = MaxTiempoCD;

    }

    // Update is called once per frame
    void Update()
    {
        InicioCD -= Time.deltaTime;
        if (InicioCD <= 0 && TiempoCD >= 0 && playing == true)
        {
            TiempoCD -= Time.deltaTime;
            TiempoText.text = ""+Mathf.RoundToInt(TiempoCD) + " \" ";
            if ((Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) && this.transform.position.x >= -5f)
            {
                this.transform.position = this.transform.position + new Vector3(-1, 0, 0) * speed * Time.deltaTime;
            }
            if ((Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) && this.transform.position.x <= 5f)
            {
                this.transform.position = this.transform.position + new Vector3(1, 0, 0) * speed * Time.deltaTime;

            }
            if (Balones >= 1)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    Instantiate(Shoot, this.transform.position, Shoot.transform.rotation);
                    ContBalones(-1);
                }
            }
            if (CurrentCD >= MaxCD)
            {
                int numrandomSpawn = Random.Range(0, Spawn.Length);
                Instantiate(Spawn[numrandomSpawn], new Vector3(Random.Range(x0, x1), y, 0), this.transform.rotation);
                CurrentCD = 0;
            }
            if (CurrentCD < MaxCD)
            {
                CurrentCD += Time.deltaTime;
            }
           
        }
        if (TiempoCD<=0 && playing==true)
        {
            read_script.PowerUp();
            playing = false;
            TiempoCD = 10;
            ContBalones(30);
            read_script.count_days++;
            read_script.daystext.text = "DIA " + "" + read_script.count_days;
        }
    }
    public void ContBalones(int numToAdd)
    {
        Balones = Balones + numToAdd;
        BalonesText.text = "x " + Balones;
    }

    public void PowerUp_Shoot(int numToAddShoot)
    {
        PwU_Shoot = PwU_Shoot + numToAddShoot;
        ShootText.text = "x " + PwU_Shoot;
    }
    public void PowerUp_GRL(int numToAddGRL)
    {
        PwU_GRL = PwU_GRL + numToAddGRL;
        GRLText.text = "x " + PwU_GRL;
    }
    public void Playing()
    {
        playing = true;
    }
}

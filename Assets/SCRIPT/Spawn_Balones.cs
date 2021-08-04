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
    // Start is called before the first frame update
    void Start()
    {
        BalonesText.text = "x " + Balones;
        InicioCD = 3;
        TiempoCD = MaxTiempoCD;
    }

    // Update is called once per frame
    void Update()
    {
        InicioCD -= Time.deltaTime;
        if (InicioCD <= 0 && TiempoCD >= 0)
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
}

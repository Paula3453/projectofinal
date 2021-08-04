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
    // Start is called before the first frame update
    void Start()
    {
        BalonesText.text = "x " + Balones;
    }

    // Update is called once per frame
    void Update()
    {
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
    public void ContBalones(int numToAdd)
    {
        Balones = Balones + numToAdd;
        BalonesText.text = "x " + Balones;
    }
}

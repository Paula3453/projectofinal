using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps_Drop : MonoBehaviour
{
    public float speed;
    Spawn_Balones Player;
    //Posición mínima y máxima de X para el cambio de carril
    public float minX;
    public float maxX;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Spawn_Balones>();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += Vector3.down * speed * Time.deltaTime;
        if (this.transform.position.y <= -2.1)
        {
            Destroy(this.gameObject);
        }
    }
}

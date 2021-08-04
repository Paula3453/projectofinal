using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BALON : MonoBehaviour
{
    public float speed;
    public Spawn_Balones Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Spawn_Balones>();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += Vector3.up * speed * Time.deltaTime;
        if (this.transform.position.y >= 6)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "PowerUp_Shoot")
        {
            Player.PowerUp_Shoot(+1);
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
        if (collision.tag == "PowerUp_GRL")
        {
            Player.PowerUp_GRL(+1);
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
}
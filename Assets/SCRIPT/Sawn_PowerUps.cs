using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sawn_PowerUps : MonoBehaviour
{
    public GameObject[] Spawn;
    public Spawn_Balones Player;
    float CurrentCD;
    public float MaxCD;
    public float x1;
    public float x0;
    public float y;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Spawn_Balones>();
        CurrentCD = MaxCD;
    }

    // Update is called once per frame
    void Update()
    {
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
}
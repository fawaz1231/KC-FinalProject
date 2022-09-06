using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uu : MonoBehaviour
{
    public GameObject[] spawns;
    float timeBtwSpawns = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeBtwSpawns = Time.deltaTime;
       
        if (timeBtwSpawns <= 0)
        {
            timeBtwSpawns = Random.Range(5f,5f);
            Vector2 spawnposition = new Vector2();
            spawnposition.x = Random.Range(-2.5f, 2.5f);
            spawnposition.y = -7;
            Instantiate(spawns[Random.Range(0, spawns.Length)], spawnposition, Quaternion.identity);
        }
    }
}

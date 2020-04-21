using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// script by: Connor Barker 1017568

public class AISpawn : MonoBehaviour
{
    public float timer = 30f;
    public GameObject Enemy;
    public Transform Spawn;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", timer, timer);
        Instantiate(Enemy, Spawn.position, Spawn.rotation);
    }

    // Update is called once per frame
    void Update()
    {      
        timer -= Time.deltaTime;

        if (timer <= 0f)
        {
            timer = 30f;
        }
        
    }

    void SpawnEnemy()
    {
        Instantiate(Enemy, Spawn.position, Spawn.rotation);
    }
}

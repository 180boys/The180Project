﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMovement : MonoBehaviour
{
    public GameObject Player;
    public GameObject Bullet;
    public GameObject BulletEmitter;
    public float BulletForwardForce;
    public float MovementSpeed;
    public float StoppingDistance;
    public Transform target;
    public bool IsShooting;
    public int burstCount = 3;
    public int Health;
    public float ProjectileOffset = 1.3f;

    // Start is called before the first frame update
    void Start()
    {
        // find the player
        Player = GameObject.FindWithTag("Player");  
    }

    // Update is called once per frame
    void Update()
    {
        // if withen a certain range, follow the player
        if (Vector3.Distance(transform.position, Player.transform.position) > StoppingDistance)
        {
            IsShooting = false;
            transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, MovementSpeed * Time.deltaTime);

        }

        // When stopped, Shoot!
        if (Vector3.Distance(transform.position, Player.transform.position) < StoppingDistance)
        {
            IsShooting = true;
        }

            transform.LookAt(Player.transform);

        // when he dies
        if (Health == 0)
        {
            Destroy(gameObject);
        }
    
    }
}


using System.Collections;
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
    public int BulletRate = 3;
    public int Health;

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

            transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, MovementSpeed * Time.deltaTime);

        }

        // When stopped, Shoot!
        if (Vector3.Distance(transform.position, Player.transform.position) < StoppingDistance)
        {
            IsShooting = true;
        }

            transform.LookAt(Player.transform);

        // shooting
        for (var i = 0; i < BulletRate; i++)
        {
            if (IsShooting == true)
            {
              //  BulletEmitter.transform.rotation=
                Instantiate(Bullet, BulletEmitter.transform.position, BulletEmitter.transform.rotation);

            }
        }
        //once attack is finished, chase the player

        // when he dies
    }
}

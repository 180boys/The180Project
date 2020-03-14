using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMovement : MonoBehaviour
{
    public GameObject Player;
    public GameObject Bullet;
    public GameObject BulletEmitter;
    public float MovementSpeed;
    public float StoppingDistance;
    public Transform target;
    public bool IsShooting;
    public int Health;
    public float ProjectileOffset = 1.3f;
    public float BulletSpeed = 5f;
    public Rigidbody Bulletrigidbody;


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
            //IsShooting = false;
            transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, MovementSpeed * Time.deltaTime);

        }

        // When stopped, Shoot!
        if (Vector3.Distance(transform.position, Player.transform.position) < StoppingDistance)
        {
           // Instantiate(Bullet, BulletEmitter.transform.position, BulletEmitter.transform.rotation );
        }

            transform.LookAt(Player.transform);
    
        // when he dies
        if (Health == 0)
        {
           Destroy(gameObject);
        }

    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMovement : MonoBehaviour
{
    public GameObject Player;
    public float MovementSpeed;
    public float StoppingDistance;
    public Transform target;
    public int Health;

    public Rigidbody Bullet;
    public Transform BulletEmitter;

    public float Spawnrate;


    // Start is called before the first frame update
    void Start()
    {
        // find the player
        Player = GameObject.FindWithTag("Player");

        Spawnrate = Time.time + 1.0f;
    }

    // Update is called once per frame
    void Update()
    { 

        

        // if withen a certain range, follow the player
        if (Vector3.Distance(transform.position, Player.transform.position) > StoppingDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, MovementSpeed * Time.deltaTime);
            CancelInvoke("Shoot");
        }
        transform.LookAt(Player.transform);

        // When stopped, Shoot!
        if (Vector3.Distance(transform.position, Player.transform.position) < StoppingDistance)
        {
            Debug.Log("Shoot!");
            InvokeRepeating("Shoot", 1.0f, 3.0f);
        }   

       
    
        // when he dies
        if (Health == 0)
        {
           Destroy(gameObject);
        }

    }

    void Shoot()
    {
        if(Time.time > Spawnrate)
        {
            Rigidbody instance = Instantiate(Bullet, BulletEmitter.position, BulletEmitter.rotation);

            instance.velocity = BulletEmitter.up * 5;

            Spawnrate += 1.0f;
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public GameObject Player;
    public float MovementSpeed;
    public float StoppingDistance;
    public Transform target;
    public int Health;

    public AudioSource Hit;
    public AudioSource Dead;
    public AudioSource Bang;

    public Rigidbody Bullet;
    public Transform BulletEmitter;

    public float Spawnrate;
    // Start is called before the first frame update
    void Start()
    {
        // find the player
        Player = GameObject.FindWithTag("Player");

        Spawnrate = 1.0f;
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
            Spawnrate -= Time.deltaTime;
            InvokeRepeating("Shoot", 1.0f, 1.0f);
        }

        // when he dies
        if (Health <= 0)
        {
            Dead.Play();
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "PlayerBullet")
        {
            Hit.Play();

            Health -= 20;
        }
    }

    void Shoot()
    {
        if (Time.time > Spawnrate)
        {
            Bang.Play();

            Rigidbody instance = Instantiate(Bullet, BulletEmitter.position, BulletEmitter.rotation);

            instance.velocity = BulletEmitter.up * 12;

            Spawnrate = 1.0f;

            CancelInvoke("Shoot");

        }
    }
}

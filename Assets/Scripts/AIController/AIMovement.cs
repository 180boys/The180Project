using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMovement : MonoBehaviour
{
    public GameObject Player;
    public GameObject Bullet;
    public float MovementSpeed;
    public float StoppingDistance;
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("Player");  
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, Player.transform.position) > StoppingDistance)
        {

            transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, MovementSpeed * Time.deltaTime);

        }

        transform.LookAt(Player.transform);

        //once stopped, shoot!
        if (Vector3.Distance(transform.position, Player.transform.position) < StoppingDistance)
        {
            GameObject bullet = Instantiate(Bullet, transform.position, Quaternion.identity) as GameObject;
        }

        //once attack is finished, chase the player


        // health

        // when he dies
    }
}

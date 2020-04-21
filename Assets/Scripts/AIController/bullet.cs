using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Script by: Connor Barker 1017568

public class bullet : MonoBehaviour
{
    public float lifetime = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, lifetime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Environment")
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Enemy")
        {
            Physics.IgnoreCollision(collision.collider, GetComponent<Collider>());
        }

        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }

    
}

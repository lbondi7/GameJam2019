using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GaurdDog : MonoBehaviour {


    public float damage = 5;
    public float health = 15;
    public int cost = 500;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void OnCollisionEnter(Collision enemy)
    {
        if (enemy.gameObject.tag == "Enemy")
        {
            health--;
            if (health <= 0)
            {
                Destroy(gameObject);
            }
        }
    }

    void OnTriggerStay2D(Collider2D enemy)
    {
        if (enemy.gameObject.tag == "Enemy")
        {
            health--;
        }
    }
}

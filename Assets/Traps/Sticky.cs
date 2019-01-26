using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sticky : MonoBehaviour {

    public float stick_amount = 2;
    public float health = 5;
    public int cost = 100;

    public 

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


    float ApplySlip()
    {
        return stick_amount;
    }
}

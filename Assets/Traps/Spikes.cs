using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour {

    public int damage = 2;
    public int health = 10;
    public int cost = 100;

    // Use this for initialization.
    void Start ()
    {
		
	}
	
	// Update is called once per frame.
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

    void OnCollisionStay2D(Collision2D enemy)
    {
        if (enemy.gameObject.tag == "Enemy")
        {
            health--;
        }
    }

    int ApplyDamage()
    {
        return damage;
    }
}

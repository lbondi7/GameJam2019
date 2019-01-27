using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slip : MonoBehaviour {

    public float slip_amount = 10;
    public int health = 5;
    public int cost = 100;

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


    void OnCollisionStay2D(Collision2D enemy)
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

    float ApplySlip()
    {
        return slip_amount;
    }
}

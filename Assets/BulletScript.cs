using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

    public float bullet_x_velocity;
    public float bullet_y_velocity;
    public float lifetime;

    Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        rb.velocity = new Vector2(bullet_x_velocity, bullet_y_velocity);
        Destroy(gameObject, lifetime);
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("HIT");
        Destroy(gameObject, 0f);
    }
}

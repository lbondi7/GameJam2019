using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

    public float bullet_x_velocity = 5f;
    float bullet_y_velocity = 0f;

    Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        rb.velocity = new Vector2(bullet_x_velocity, bullet_y_velocity);
        Destroy(gameObject, 3f);
	}
}

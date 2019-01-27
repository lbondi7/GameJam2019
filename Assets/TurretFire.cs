using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretFire : MonoBehaviour {

    public GameObject projectile;
    Vector2 bulletPos;

    public int fire_rate;

    float timer;
    int seconds;

	// Use this for initialization
	void Start () {
        projectile.GetComponent<BulletScript>().bullet_x_velocity *= GetComponent<SpriteRenderer>().flipX ? -1 : 1;


    }

    // Update is called once per frame
    void Update () {

        timer += Time.deltaTime;
        seconds = (int)timer;

        if (seconds == fire_rate/*SECONDS*/)
        {
            Debug.Log("FIRE");
            bulletPos = transform.position;
            Instantiate(projectile, bulletPos, Quaternion.identity);
            timer = 0;
        }

	}

}

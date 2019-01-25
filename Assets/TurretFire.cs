using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretFire : MonoBehaviour {

    public GameObject bulletToRight, bulletToLeft;
    Vector2 bulletPos;
    float timer;
    int seconds;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        timer += Time.deltaTime;
        seconds = (int)timer;
        Debug.Log(seconds);

        if (seconds == 3/*SECONDS*/)
        {
            Fire();

            Debug.Log("FIRE");
            bulletPos = transform.position;
            Instantiate(bulletToRight, bulletPos, Quaternion.identity);
            timer = 0;
        }

	}

    void Fire()
    {

    }
}

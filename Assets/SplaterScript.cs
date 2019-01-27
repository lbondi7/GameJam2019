using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplaterScript : MonoBehaviour {

    public GameObject paint_splatter;
    Vector2 spawn_pos;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {

        spawn_pos = transform.position;
        Instantiate(paint_splatter, spawn_pos, Quaternion.identity);

    }
}

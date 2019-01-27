using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPlayer : MonoBehaviour {

    Vector2 resetPos;
	void Start () {
        resetPos = transform.Find("ResetPos").transform.position;
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            collision.transform.position = new Vector2(resetPos.x,collision.transform.position.y);
        }
    }
}

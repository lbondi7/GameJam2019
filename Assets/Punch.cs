using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punch : MonoBehaviour {

    public bool punch;
    public AudioSource hitsound;


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (punch && collision.CompareTag("Enemy") && collision != null)
        {
            Debug.Log("hit");

            GameObject.Destroy(collision.gameObject);
            hitsound.Play();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (punch && collision.CompareTag("Enemy") && collision != null)
        {
            Debug.Log("hit");

            GameObject.Destroy(collision.gameObject);
        }
    }

}


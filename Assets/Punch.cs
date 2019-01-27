using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punch : MonoBehaviour {

    public bool punch;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (punch && collision.CompareTag("Enemy") && collision != null)
        {
            Debug.Log("hit");

            GameObject.Destroy(collision.gameObject);
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


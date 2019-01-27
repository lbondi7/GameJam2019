using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GaurdDog : MonoBehaviour {


    public int killCount = 20;

    private void Update()
    {
        if(killCount == 0)
        {
            GameObject.Destroy(this);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy") && collision != null)
        {
            GameObject.Destroy(collision.gameObject);
            --killCount;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sticky : MonoBehaviour
{
    public float speedReduce = 0.15f;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Enemy") && collision != null)
        {
            collision.GetComponent<EnemyMove>().speed = speedReduce;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.CompareTag("Enemy") && collision != null)
        {
            collision.GetComponent<EnemyMove>().speed = 0.2f;
        }
    }

}

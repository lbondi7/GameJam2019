using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartHealth : MonoBehaviour {

    public int health = 200;
    public int healthReduction = 1;
    public bool end_game = false;
    private void Update()
    {
        end_game = health == 0;

        if(end_game)
        {
            Application.Quit();
        }
    }
    // Use this for initialization
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy") && collision != null && health > 0)
        {
            health -= healthReduction;
            GameObject.Destroy(collision.gameObject);
        }
    }
}

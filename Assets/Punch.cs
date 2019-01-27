using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punch : MonoBehaviour {

    public bool punch;
    public GameObject coin;
    public Transform prefab;
    public AudioSource punchsound;
    public void Update()
    {
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (punch && collision.CompareTag("Enemy") && collision != null)
        {
            Debug.Log("hit");

            GameObject.Destroy(collision.gameObject);
            Spawncoin();
            punchsound.Play();

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (punch && collision.CompareTag("Enemy") && collision != null)
        {
            Debug.Log("hit");

            GameObject.Destroy(collision.gameObject);
            Spawncoin();
        }
    }



    private void Spawncoin()
    {
        for (int i = 0; i < 2; i++)
        {
            Instantiate(coin, new Vector2(0, -100), Quaternion.identity);
        }
    }

}


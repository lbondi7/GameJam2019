using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetHitScript : MonoBehaviour {

    bool slowed = false;
    public int slowed_timer;

    float timer;
    int seconds;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (slowed)
        {
            timer -= Time.deltaTime;
            seconds = (int)timer;

            if (seconds == 0)
            {
                slowed = false;
            }
            else
            {
                transform.Rotate(Vector3.forward);
            }
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!slowed)
        {
            timer = slowed_timer;
            slowed = true;
        }

    }
}

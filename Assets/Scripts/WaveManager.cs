using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour {

    [HideInInspector]
    public int wave = 4;

    [HideInInspector]
    public int enemy_amount = 0;

    [HideInInspector]
    public bool in_wave = false;

    [HideInInspector]
    public float timer = 5.0f;

	// Use this for initialization
	void Start () {
		


	}
	
	// Update is called once per frame
	void Update () {

        if (!in_wave)
        {
            timer -= Time.deltaTime;

            Debug.Log(timer);

            if(timer <= 0)
            {
                in_wave = true;
            }
        }
        else if(in_wave)
        {
            if(wave == 1)
            {
                enemy_amount = 10;
            }
            else if (wave == 2)
            {
                enemy_amount = 20;
            }
            else if (wave == 3)
            {
                enemy_amount = 30;
            }
            else if (wave == 4)
            {
                enemy_amount = 50;
            }
            else if (wave == 5)
            {
                enemy_amount = 75;
            }
            else if (wave == 6)
            {
                enemy_amount = 100;
            }
            else if (wave == 7)
            {
                enemy_amount = 10;
            }
            else if (wave == 8)
            {
                enemy_amount = 10;
            }
            else if (wave == 9)
            {
                enemy_amount = 10;
            }
            else if (wave == 10)
            {
                enemy_amount = 10;
            }
            else if (wave == 11)
            {
                enemy_amount = 10;
            }
            else if (wave == 12)
            {
                enemy_amount = 10;
            }
            else if (wave == 13)
            {
                enemy_amount = 10;
            }
        }
	}
}

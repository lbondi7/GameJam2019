using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour {

    private int enemy_count = 0;
    private GameObject enemy;
    private GameObject[] spawnPoints;
    float timer = 0.0f;


    void Awake()
    {
        enemy = GameObject.FindGameObjectWithTag("Enemy");
        if(spawnPoints == null)
            spawnPoints = GameObject.FindGameObjectsWithTag("SpawnPoint");
    }

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {

        timer += Time.deltaTime;

        if(timer > 1.0f)
        {
            timer = 0.0f;
            Instantiate(enemy, spawnPoints[Random.RandomRange(0, spawnPoints.Length)].transform.position, Quaternion.identity);
            enemy_count++;
        }
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour {

    private int enemy_count = 0;
    public GameObject enemy0;
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    private GameObject[] spawnPoints;

    float enemyTimer0 = 0.0f;
    float enemyTimer1 = 0.0f;
    float enemyTimer2 = 0.0f;
    float enemyTimer3 = 0.0f;

    public EnemyMove enemyMove0;
    public EnemyMove enemyMove1;
    public EnemyMove enemyMove2;
    public EnemyMove enemyMove3;

    void Awake()
    {
        if(spawnPoints == null)
            spawnPoints = GameObject.FindGameObjectsWithTag("SpawnPoint");
    }

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {

        enemyTimer0 += Time.deltaTime;
        enemyTimer1 += Time.deltaTime;
        enemyTimer2 += Time.deltaTime;
        enemyTimer3 += Time.deltaTime;

        if (enemy_count < 50)
        {
            if (enemyTimer0 > 1.0f)
            {
                enemyTimer0 = 0.0f;
                Instantiate(enemy0, spawnPoints[0].transform.position, Quaternion.identity);
                enemyMove0.route = Random.Range(0, 4);
                enemy_count++;
            }
            if (enemyTimer1 > 2.0f)
            {
                enemyTimer1 = 0.0f;
                Instantiate(enemy1, spawnPoints[1].transform.position, Quaternion.identity);
                enemyMove1.route = Random.Range(0, 4);
                enemy_count++;
            }
            if (enemyTimer2 > 3.0f)
            {
                enemyTimer2 = 0.0f;
                Instantiate(enemy2, spawnPoints[2].transform.position, Quaternion.identity);
                enemyMove2.route = Random.Range(0, 4);
                enemy_count++;
            }
            if (enemyTimer3 > 5.0f)
            {
                enemyTimer3 = 0.0f;
                Instantiate(enemy3, spawnPoints[3].transform.position, Quaternion.identity);
                enemyMove3.route = Random.Range(0, 4);
                enemy_count++;
            }
        }
    }
}

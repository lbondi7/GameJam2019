using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour {

    private int enemy_count = 0;

    [HideInInspector]
    public int enemy_alive = 0;

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

    public WaveManager wave_manager;

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

        if (!wave_manager.in_wave)
        {
            enemyTimer0 = 0.0f;
            enemyTimer1 = 0.0f;
            enemyTimer2 = 0.0f;
            enemyTimer3 = 0.0f;
            enemy_alive = 0;
            enemy_count = 0;
        }
        else if(wave_manager.in_wave)
        {
            enemyTimer0 += Time.deltaTime;
            enemyTimer1 += Time.deltaTime;
            enemyTimer2 += Time.deltaTime;
            enemyTimer3 += Time.deltaTime;

            if (enemy_count < wave_manager.enemy_amount)
            {
                if (enemyTimer0 > 1.0f)
                {
                    int rand = Random.RandomRange(0,3);
                    enemyTimer0 = 0.0f;
                    Instantiate(enemy0, spawnPoints[rand].transform.position, Quaternion.identity);
                    enemyMove0.route = rand;
                    enemyMove0.setUp(1);
                    enemy_count++;
                    enemy_alive++;
                }
                if (enemyTimer1 > 2.0f && wave_manager.wave >= 3)
                {
                    int rand = Random.RandomRange(0,3);
                    enemyTimer1 = 0.0f;
                    Instantiate(enemy1, spawnPoints[rand].transform.position, Quaternion.identity);
                    enemyMove1.route = rand;
                    enemyMove1.setUp(1);
                    enemy_count++;
                    enemy_alive++;
                }
                if (enemyTimer2 > 3.0f && wave_manager.wave >= 6)
                {
                    int rand = Random.RandomRange(0,3);
                    enemyTimer2 = 0.0f;
                    Instantiate(enemy2, spawnPoints[rand].transform.position, Quaternion.identity);
                    enemyMove2.route = rand;
                    enemyMove2.setUp(2);
                    enemy_count++;
                    enemy_alive++;
                }
                if (enemyTimer3 > 5.0f && wave_manager.wave >= 10)
                {
                    int rand = Random.RandomRange(0,3);
                    enemyTimer3 = 0.0f;
                    Instantiate(enemy3, spawnPoints[rand].transform.position, Quaternion.identity);
                    enemyMove3.route = rand;
                    enemyMove3.setUp(3);
                    enemy_count++;
                    enemy_alive++;
                }
            }
            else if (enemy_alive <= 0)
            {
                wave_manager.in_wave = false;
                wave_manager.timer = 5.0f;
                wave_manager.wave++;
            }
        }
    }
}

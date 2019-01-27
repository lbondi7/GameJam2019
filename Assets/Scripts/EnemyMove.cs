using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {


    public GameObject enemy;
    int next_waypoint = 1;

    [HideInInspector]
    public int route = 0;
    [HideInInspector]
    public int health = 0;
    public int enemy_speed = 0;

    private GameObject[] waypoints  = new GameObject[1];

    public SpawnEnemy enemy_manager;

    private float t = 0.0f;

    void Awake()
    {
        //enemy_speed = 100;
    }

    // Use this for initialization
    void Start()
    {

        if (route == 0)
            waypoints = GameObject.FindGameObjectsWithTag("Waypoint0");
        else if (route == 1)
            waypoints = GameObject.FindGameObjectsWithTag("Waypoint1");
        else if (route == 2)
            waypoints = GameObject.FindGameObjectsWithTag("Waypoint2");
        else if (route == 3)
            waypoints = GameObject.FindGameObjectsWithTag("Waypoint3");

        //Debug.Log(waypoints.Length.ToString());
        //Debug.Log(difference.Length.ToString());
        //Debug.Log(enemy.ToString());
    }
	
	// Update is called once per frame
	void Update () {

        t = enemy_speed * Time.deltaTime;

        if (enemy.gameObject != null)
        {
            int target = 0;
            for(int i = 0; i < waypoints.Length; i++)
            {
                if(waypoints[i].name == "Waypoint_" + next_waypoint.ToString())
                {
                    target = i;
                }
            }

            if (enemy.transform.position != waypoints[target].transform.position && 
                this.gameObject.name != "Enemy" && this.gameObject.name != "Enemy1" && 
                this.gameObject.name != "Enemy2" && this.gameObject.name != "Enemy3")
            {              
                enemy.transform.position = Vector2.MoveTowards(enemy.transform.position, waypoints[target].transform.position, t);
                Debug.Log(enemy_speed);
            }
            else if (enemy.transform.position == waypoints[target].transform.position)
            {
                next_waypoint++;
            }

            if(next_waypoint > waypoints.Length)
            {
                Destroy(this.gameObject);
                enemy_manager.enemy_alive--;
            }
        }
    }

    public void setUp(int value)
    {
        if (value == 0)
        {
            health = 0;
            enemy_speed = 20;
        }
        else if (value == 1)
        {
            health = 2;
            enemy_speed = 10;
        }
        else if (value == 2)
        {
            health = 3;
            enemy_speed = 30;
        }
        else if (value == 3)
        {
            health = 5;
            enemy_speed = 50;
        }
    }
}

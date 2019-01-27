using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {

    // [HideInInspector]
    public int route = 0;
    //[HideInInspector]
    public int health = 0;
    //[HideInInspector]
    public float enemySpeed = 0;

    int target = 0;

    public GameObject[] route0;
    public GameObject[] route1;
    public GameObject[] route2;
    public GameObject[] route3;


    public SpawnEnemy enemy_manager;

    private float t = 0.0f;

    // Use this for initialization
    void Start()
    {
        //if (route == 0)
        //    waypoints = GameObject.FindGameObjectsWithTag("Waypoint0");
        //else if (route == 1)
        //    waypoints = GameObject.FindGameObjectsWithTag("Waypoint1");
        //else if (route == 2)
        //    waypoints = GameObject.FindGameObjectsWithTag("Waypoint2");
        //else if (route == 3)
        //    waypoints = GameObject.FindGameObjectsWithTag("Waypoint3");
    }
	
	// Update is called once per frame
	void Update () {

        if  (this.gameObject.name != "Enemy" && this.gameObject.name != "Enemy1" &&
                this.gameObject.name != "Enemy2" && this.gameObject.name != "Enemy3")
        {
            t = enemySpeed * Time.deltaTime;
            //for(int i = 0; i < waypoints.Length; i++)
            //{
            //    if(waypoints[i].name == "Waypoint_" + next_waypoint.ToString())
            //    {
            //        target = i;
            //    }
            //}

            if (route == 0)
            {

                if (this.transform.position != route0[target].transform.position)
                {
                    this.transform.position = Vector2.MoveTowards(this.transform.position, route0[target].transform.position, t);
                }
                else if (this.transform.position == route0[target].transform.position)
                {
                    target++;
                }
                if (target > route0.Length || health <= 0)
                {
                    Destroy(this.gameObject);
                    enemy_manager.enemy_alive--;
                }
            }
            else if (route == 1)
            {

                if (this.transform.position != route1[target].transform.position)
                {
                    this.transform.position = Vector2.MoveTowards(this.transform.position, route1[target].transform.position, t);
                }
                else if (this.transform.position == route1[target].transform.position)
                {
                    target++;
                }
            
                if (target > route1.Length || health <= 0)
                {
                    Destroy(this.gameObject);
                    enemy_manager.enemy_alive--;
                }
            }
            else if (route == 2)
            {

                if (this.transform.position != route2[target].transform.position)
                {
                    this.transform.position = Vector2.MoveTowards(this.transform.position, route2[target].transform.position, t);
                }
                else if (this.transform.position == route2[target].transform.position)
                {
                    target++;
                }
                if (target > route2.Length || health <= 0)
                {
                    Destroy(this.gameObject);
                    enemy_manager.enemy_alive--;
                }
            }
            else if (route == 3)
            {

                if (this.transform.position != route3[target].transform.position)
                {
                    this.transform.position = Vector2.MoveTowards(this.transform.position, route3[target].transform.position, t);
                }
                else if (this.transform.position == route3[target].transform.position)
                {
                    target++;
                }
                if (target > route3.Length || health <= 0)
                {
                    Destroy(this.gameObject);
                    enemy_manager.enemy_alive--;
                }
            }
        }
    }

    public void setUp(int value)
    {
        if (value == 0)
        {
            health = 1;
            enemySpeed = 20;
        }
        else if (value == 1)
        {
            health = 2;
            enemySpeed = 10;
        }
        else if (value == 2)
        {
            health = 3;
            enemySpeed = 30;
        }
        else if (value == 3)
        {
            health = 5;
            enemySpeed = 50;
        }
    }
}

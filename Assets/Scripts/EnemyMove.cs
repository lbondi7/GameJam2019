using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {

    
    public GameObject enemy;
    int next_waypoint = 1;

    [HideInInspector]
    public int route = 0;

    private GameObject[] waypoints = new GameObject[5];

    Vector2 position;
    private float t;

    void Awake()
    {
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

        position = enemy.transform.position;

        //Debug.Log(next_waypoint);
        //Debug.Log(waypoints.Length.ToString());
        //Debug.Log(difference.Length.ToString());
        //Debug.Log(enemy.ToString());
    }
	
	// Update is called once per frame
	void Update () {


        //Debug.Log(next_waypoint);
        t += (Time.deltaTime / 5);

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
                Vector2 new_pos = Vector2.Lerp(position, waypoints[target].transform.position, t);
                enemy.transform.position = new_pos;
            }
            else if (enemy.transform.position == waypoints[target].transform.position)
            {
                next_waypoint++;
                position = enemy.transform.position;
                t = 0;
            }

            if(next_waypoint > waypoints.Length)
            {
                Destroy(this.gameObject);
            }
        }
    }
}

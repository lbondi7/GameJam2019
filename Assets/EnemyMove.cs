using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {


    private GameObject enemy;
    private int target_waypoint = 6;
    private int current_waypoint = 0;
    private GameObject[] waypoints;
    float[] difference = new float[] { };

    // Use this for initialization
    void Start () {
        if (waypoints == null)
            waypoints = GameObject.FindGameObjectsWithTag("Waypoint");

        enemy = this.GetComponent<GameObject>();

        for(int i = 0; i < waypoints.Length; i++)
        {
            difference[i] = Mathf.Sqrt((enemy.transform.position.x * waypoints[i].transform.position.x) + (enemy.transform.position.y * waypoints[i].transform.position.y));
        }

        for (int i = 0; i < difference.Length; i++)
        {
            for (int j = 0; j < difference.Length; j++)
            {
                if(difference[i] < difference[j])
                {
                    current_waypoint = i;
                }
            }
        }
    }
	
	// Update is called once per frame
	void Update () {



	}
}

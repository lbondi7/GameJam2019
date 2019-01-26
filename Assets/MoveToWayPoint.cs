using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToWayPoint : MonoBehaviour {

    public float speed = 2.0f;
    private int waypoint_count = 0;
    public GameObject[] waypoints;
    public Vector2 target_point;

	// Use this for initialization
	void Start ()
    {
        waypoints = GameObject.FindGameObjectsWithTag("WayPoint");
    }
	
	// Update is called once per frame
	void Update ()
    {
        float step = speed * Time.deltaTime;
        
        transform.position = Vector2.MoveTowards(transform.position, target_point, step);
	}

    void OnCollisionEnter(Collision waypoint)
    {
        if(waypoint.gameObject.tag =="WayPoint")
        {
            waypoint_count++;
            target_point = waypoints[waypoint_count].transform.position;
        }
    }
}

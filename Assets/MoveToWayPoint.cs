using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToWayPoint : MonoBehaviour {

    public float speed = 2.0f;
    private int waypoint_count = 5;
    public GameObject[] waypoints;
    public Vector2 target_point;

	// Use this for initialization
	void Start ()
    {
        waypoints = GameObject.FindGameObjectsWithTag("WayPoint");
        target_point = new Vector2(waypoints[waypoint_count].gameObject.transform.position.x, waypoints[waypoint_count].gameObject.transform.position.y);
    }
	
	// Update is called once per frame
	void Update ()
    {
        float step = speed * Time.deltaTime;
        
        transform.position = Vector2.MoveTowards(transform.position, target_point, step);
	}


    void OnTriggerEnter2D(Collider2D waypoint)
    {
        if (waypoint.gameObject.tag == "WayPoint")
        {
            waypoint_count--;
            target_point = new Vector2(waypoints[waypoint_count].gameObject.transform.position.x, waypoints[waypoint_count].gameObject.transform.position.y);
        }
    }
}

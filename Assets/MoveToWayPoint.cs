using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToWayPoint : MonoBehaviour {
    public int health = 10;
    public float speed = 2.0f;
    private int waypoint_count = 2;
    public GameObject[] waypoints;
    public Vector2 target_point;

    private Spikes spikes_script;
    private Sticky sticky_script;
    private Slip slip_script;

    public 

	// Use this for initialization
	void Start ()
    {
        spikes_script = GetComponent<Spikes>();
        sticky_script = GetComponent<Sticky>();
        slip_script = GetComponent<Slip>();

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

    void OnTriggerStay2D(Collider2D trap)
    {
        GameObject collided_object;

        if (trap.gameObject.name == "Spikes")
        {
            health -= spikes_script.damage;
        }

        if (trap.gameObject.name == "Sticky")
        {
            speed -= sticky_script.stick_amount;
        }

        if (trap.gameObject.name == "")
        {

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClimbStaris : MonoBehaviour {

    GameObject player;
    StairTrigger bottomTrigger;
    StairTrigger topTrigger;
    Transform topPos;
    Transform bottomPos;
	// Use this for initialization
	void Start ()
    {
        player = GameObject.FindGameObjectWithTag("Player").gameObject;
        bottomTrigger = transform.Find("StairPoints").Find("BottomTrigger").GetComponent<StairTrigger>();
        topTrigger = transform.Find("StairPoints").Find("TopTrigger").GetComponent<StairTrigger>();
        topPos = transform.Find("StairPoints").Find("TopSpawn").transform;
        bottomPos = transform.Find("StairPoints").Find("BottomSpawn").transform;

    }

    // Update is called once per frame
    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.S) || Input.GetAxis("VerticalDPD") == -1 && topTrigger.triggered)
        {
            player.transform.position = bottomPos.position;
        }
        else if (Input.GetKeyDown(KeyCode.W) || Input.GetAxis("VerticalDPD") == 1 && bottomTrigger.triggered)
        {
            player.transform.position = topPos.position;
        }
    }
}

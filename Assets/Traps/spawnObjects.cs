using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnObjects : MonoBehaviour {


    public GameObject spike_object;
    public GameObject sticky_object;
    public GameObject gaurddog_object;
    public Camera camera;

    public GameObject[] trap_array;

    // Use this for initialization
    public enum TrapState
    {
        NONE = -1,
        SPIKES = 0,
        STICKY = 1,
        GAURDDOG = 2
    }

    public TrapState currently_selected_trap = TrapState.NONE;

	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        camera.ScreenToWorldPoint(Input.mousePosition);

        transform.position = Camera.main.ScreenToViewportPoint(Input.mousePosition);

        if (Input.GetMouseButtonDown(0) && currently_selected_trap == TrapState.SPIKES)
        {
            GameObject newObj = (GameObject)Instantiate(spike_object, camera.ScreenToWorldPoint(Input.mousePosition), Quaternion.identity) as GameObject;
            newObj.transform.position = new Vector3(camera.ScreenToWorldPoint(Input.mousePosition).x, camera.ScreenToWorldPoint(Input.mousePosition).y, 0);
        }

        if (Input.GetMouseButtonDown(0) && currently_selected_trap == TrapState.STICKY)
        {
            GameObject newObj = (GameObject)Instantiate(sticky_object, camera.ScreenToWorldPoint(Input.mousePosition), Quaternion.identity) as GameObject;
            newObj.transform.position = new Vector3(camera.ScreenToWorldPoint(Input.mousePosition).x, camera.ScreenToWorldPoint(Input.mousePosition).y, 0);
        }

        if (Input.GetMouseButtonDown(0) && currently_selected_trap == TrapState.GAURDDOG)
        {
            GameObject newObj = (GameObject)Instantiate(gaurddog_object, camera.ScreenToWorldPoint(Input.mousePosition), Quaternion.identity) as GameObject;
            newObj.transform.position = new Vector3(camera.ScreenToWorldPoint(Input.mousePosition).x, camera.ScreenToWorldPoint(Input.mousePosition).y, 0);
        }
    }

    public void setSpikeActive()
    {
        currently_selected_trap = TrapState.SPIKES;
    }

    public void setStickyActive()
    {
        currently_selected_trap = TrapState.STICKY;
    }

    public void setGaurdDogActive()
    {
        currently_selected_trap = TrapState.GAURDDOG;
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnObjects : MonoBehaviour {


    public GameObject spike_object;
    public GameObject sticky_object;
    public GameObject gaurddog_object;
    public Camera camera;
    public GameObject player;
    public PlayerManager player_manager;

    // Use this for initialization
    public enum ClickState
    {
        NONE = -1,
        SPIKES = 0,
        STICKY = 1,
        GAURDDOG = 2,
        BAT = 3,
        SPATULA = 4,
        GUITAR = 5,
        HAMMER = 6
    }

    public ClickState currently_selected_trap = ClickState.NONE;

	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        camera.ScreenToWorldPoint(Input.mousePosition);

        transform.position = Camera.main.ScreenToViewportPoint(Input.mousePosition);

        if (Input.GetKeyDown(KeyCode.Joystick1Button0) && (int)player_manager.menu_selection == (int)ClickState.SPIKES)
        {
            GameObject newObj = (GameObject)Instantiate(spike_object, player.transform.position, Quaternion.identity) as GameObject;
            newObj.transform.position = new Vector3(player.transform.position.x, player.transform.position.y - 5, 0);
        }

        if (Input.GetKeyDown(KeyCode.Joystick1Button0) && (int)player_manager.menu_selection == (int)ClickState.STICKY)
        {
            GameObject newObj = (GameObject)Instantiate(sticky_object, player.transform.position, Quaternion.identity) as GameObject;
            newObj.transform.position = new Vector3(player.transform.position.x, player.transform.position.y - 5, 0);
        }

        if (Input.GetKeyDown(KeyCode.Joystick1Button0) && (int)player_manager.menu_selection == (int)ClickState.GAURDDOG)
        {
            GameObject newObj = (GameObject)Instantiate(gaurddog_object, player.transform.position, Quaternion.identity) as GameObject;
            newObj.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, 0);
            //GameObject newObj = (GameObject)Instantiate(gaurddog_object, camera.ScreenToWorldPoint(Input.mousePosition), Quaternion.identity) as GameObject;
            //newObj.transform.position = new Vector3(camera.ScreenToWorldPoint(Input.mousePosition).x, camera.ScreenToWorldPoint(Input.mousePosition).y, 0);
        }

    }

    public void setSpikeActive()
    {
        currently_selected_trap = ClickState.SPIKES;
    }

    public void setStickyActive()
    {
        currently_selected_trap = ClickState.STICKY;
    }

    public void setGaurdDogActive()
    {
        currently_selected_trap = ClickState.GAURDDOG;
    }

    public void setHammerActive()
    {
        currently_selected_trap = ClickState.HAMMER;
    }

    public void setSpatulaActive()
    {
        currently_selected_trap = ClickState.SPATULA;
    }

    public void setGuitarActive()
    {
        currently_selected_trap = ClickState.GUITAR;
    }

    public void setBatActive()
    {
        currently_selected_trap = ClickState.BAT;
    }
}

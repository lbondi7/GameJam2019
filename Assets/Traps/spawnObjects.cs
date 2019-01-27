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
    public GameObject[] turretPos;
    public TurretCams turretCams;
    public GameObject eggLauncher;
    public GameObject paint;
    public GameObject toiletRoll;
    public GameObject guitar;
    public GameObject bat;
    public GameObject spatular;
    public GameObject hammer;
    public Transform punchPos;

    public Point_UI test;

    // Use this for initialization
    public enum ClickState
    {
        SPIKES = 0,
        STICKY = 1,
        GAURDDOG = 2,
        TOILETPAPER = 3,
        PAINT = 4,
        EGGLAUNCHER = 5,
        GUITAR = 6,
        BAT = 7,
        SPATULA = 8,
        HAMMER = 9
    }

    public ClickState currently_selected_trap = ClickState.SPIKES;

	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (!player_manager.turret_mode)
        {
            camera.ScreenToWorldPoint(Input.mousePosition);
            transform.position = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        }

        if (Input.GetKeyDown(KeyCode.Joystick1Button0) && (int)player_manager.menu_selection == (int)ClickState.SPIKES)
        {
            if (test.Money >= 10)
            {
                GameObject newObj = (GameObject)Instantiate(spike_object, player.transform.position, Quaternion.identity) as GameObject;
                newObj.transform.position = new Vector3(player.transform.position.x, player.transform.position.y - 5, 0);
                test.Money -= 10;
            }
        }

        if (Input.GetKeyDown(KeyCode.Joystick1Button0) && (int)player_manager.menu_selection == (int)ClickState.STICKY)
        {
            if (test.Money >= 50)
            {
                GameObject newObj = (GameObject)Instantiate(sticky_object, player.transform.position, Quaternion.identity) as GameObject;
                newObj.transform.position = new Vector3(player.transform.position.x, player.transform.position.y - 5, 0);
                test.Money -= 50;
            }
        
        }

        if (Input.GetKeyDown(KeyCode.Joystick1Button0) && (int)player_manager.menu_selection == (int)ClickState.GAURDDOG)
        {
            if (test.Money >= 100)
            {
                GameObject newObj = (GameObject)Instantiate(gaurddog_object, player.transform.position, Quaternion.identity) as GameObject;
                newObj.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, 0);
                //GameObject newObj = (GameObject)Instantiate(gaurddog_object, camera.ScreenToWorldPoint(Input.mousePosition), Quaternion.identity) as GameObject;
                //newObj.transform.position = new Vector3(camera.ScreenToWorldPoint(Input.mousePosition).x, camera.ScreenToWorldPoint(Input.mousePosition).y, 0);
                test.Money -= 100;
            }
        }

        if(Input.GetKeyDown(KeyCode.Joystick1Button0) && (int)player_manager.menu_selection == (int)ClickState.TOILETPAPER)
        {
            if (test.Money >= 100)
            {
                createTurret(toiletRoll, false);
                test.Money -= 100;
            }
        }

        if (Input.GetKeyDown(KeyCode.Joystick1Button0) && (int)player_manager.menu_selection == (int)ClickState.PAINT)
            if (test.Money >= 200)
            {
            createTurret(paint, true);
                test.Money -= 200;
            }

        if (Input.GetKeyDown(KeyCode.Joystick1Button0) && (int)player_manager.menu_selection == (int)ClickState.EGGLAUNCHER)
        {
            if (test.Money >= 300)
            {
                createTurret(eggLauncher, false);
                test.Money -= 300;
            }
            
        }

        if(Input.GetKeyDown(KeyCode.Joystick1Button0) && (int)player_manager.menu_selection == (int)ClickState.GUITAR)
        {
            createWeapon(guitar);
            if (test.Money >= 30)
            {
                GameObject weapon = (GameObject)Instantiate(guitar, punchPos.position, Quaternion.identity) as GameObject;
                weapon.transform.parent = punchPos;
                test.Money -= 30;
            }
        }

        if (Input.GetKeyDown(KeyCode.Joystick1Button0) && (int)player_manager.menu_selection == (int)ClickState.BAT)
        {
            createWeapon(bat);
            if (test.Money >= 40)
            {
                GameObject weapon = (GameObject)Instantiate(bat, punchPos.position, Quaternion.identity) as GameObject;
                weapon.transform.parent = punchPos;
                test.Money -= 40;
            }
        }

        if (Input.GetKeyDown(KeyCode.Joystick1Button0) && (int)player_manager.menu_selection == (int)ClickState.SPATULA)
        {
            createWeapon(spatular);
            if (test.Money >= 60)
            {
                GameObject weapon = (GameObject)Instantiate(spatular, punchPos.position, Quaternion.identity) as GameObject;
                weapon.transform.parent = punchPos;
                test.Money -= 60;
            }
        }

        if (Input.GetKeyDown(KeyCode.Joystick1Button0) && (int)player_manager.menu_selection == (int)ClickState.HAMMER)
        {
            createWeapon(hammer);
        }
    }

    private void createWeapon(GameObject weapon_)
    {
        if (!punchPos.Find("Weapon(Clone)"))
        {
            GameObject weapon = (GameObject)Instantiate(weapon_, punchPos.position, Quaternion.identity) as GameObject;
            weapon.transform.parent = punchPos;
            if (test.Money >= 200)
            {
                GameObject weapon = (GameObject)Instantiate(hammer, punchPos.position, Quaternion.identity) as GameObject;
                weapon.transform.parent = punchPos;
                test.Money -= 200;
            }
        }
        else
        {
            punchPos.Find("Weapon(Clone)").GetComponent<SpriteRenderer>().sprite = weapon_.GetComponent<SpriteRenderer>().sprite;
        }
    }

    private void createTurret(GameObject turret, bool flip)
    {
        if (Input.GetKeyDown(KeyCode.Joystick1Button0) && player_manager.turret_mode)
        {
            if (!turretPos[turretCams.turrentIndex].GetComponent<turretSpot>().turret)
            {
                GameObject newTurret = (GameObject)Instantiate(turret, turretPos[turretCams.turrentIndex].transform.position, Quaternion.identity) as GameObject;
                newTurret.transform.parent = turretPos[turretCams.turrentIndex].transform;


                if ((turretCams.turrentIndex < 3 && !flip) || (turretCams.turrentIndex  > 2 && flip))
                {
                    newTurret.GetComponent<SpriteRenderer>().flipX = true;
                }

            }
            //else
            //{
 
            //    turretPos[turretCams.turrentIndex].transform.Find("Turret(Clone)").GetComponent<SpriteRenderer>().sprite = turret.GetComponent<SpriteRenderer>().sprite;
                
            //}
            turretPos[turretCams.turrentIndex].GetComponent<turretSpot>().turret = true;

        }
        player_manager.turret_mode = true;
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

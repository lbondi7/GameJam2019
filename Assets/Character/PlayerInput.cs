using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour {

    // getjoystickbutton0 = a;
    public PlayerManager player_manager;
    private bool next_menu_item = false;

   void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Joystick1Button1))
        {
            if(player_manager.turret_mode)
            {
                player_manager.turret_mode = false;
            }
            else
            {
                player_manager.build_mode = !player_manager.build_mode;
            }
        }


        if(player_manager.build_mode && !player_manager.turret_mode)
        {

            if(next_menu_item && Input.GetAxisRaw("HorizontalDPD") > 0)
            {              
                next_menu_item = false;
                player_manager.menu_selection = player_manager.menu_selection < PlayerManager.ClickState.HAMMER ? player_manager.menu_selection + 1 : 0;
            }
            else if(next_menu_item && Input.GetAxisRaw("HorizontalDPD") < 0)
            {

                    next_menu_item = false;
                player_manager.menu_selection = player_manager.menu_selection > 0 ? player_manager.menu_selection - 1:PlayerManager.ClickState.HAMMER;                
            }
            else if(Input.GetAxisRaw("HorizontalDPD") == 0)
            {
                next_menu_item = true;

            }

            if ((int)player_manager.menu_selection < -1)
            {
                player_manager.menu_selection = PlayerManager.ClickState.HAMMER;
            }

            if ((int)player_manager.menu_selection > 9)
            {
                player_manager.menu_selection = PlayerManager.ClickState.SPIKES;
            }
        }

    }
}

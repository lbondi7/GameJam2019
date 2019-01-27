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
                if(player_manager.build_mode == true)
                {
                    player_manager.build_mode = false;
                }
                else
                {
                    player_manager.build_mode = true;
                }
            }


        if(player_manager.build_mode)
        {

            if(Input.GetAxisRaw("HorizontalDPD") == 1)
            {
                if (player_manager.build_mode)
                {
                
                    if(next_menu_item)
                    {
                        next_menu_item = false;
                        player_manager.menu_selection++;
                    }
                    next_menu_item = true;
                }
            }
            else if(Input.GetAxisRaw("HorizontalDPD") == -1)
            {
                if (player_manager.build_mode)
                {
                
                    if (next_menu_item)
                    {
                        next_menu_item = false;
                        player_manager.menu_selection--;
                    }
                    next_menu_item = true;
                }
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

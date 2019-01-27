using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class spikechangesprite : MonoBehaviour {


    public Button button;
    public Sprite Image1;
    public Sprite Image2;
    public PlayerManager player_manager;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (player_manager.build_mode)
        {
            if (player_manager.menu_selection == PlayerManager.ClickState.SPIKES)
            {
                button.image.sprite = Image2;
            }
            else if(player_manager.menu_selection != PlayerManager.ClickState.SPIKES)
            {
                button.image.sprite = Image1;
            }
        }
        else if(!player_manager.build_mode)
        {
            button.image.sprite = Image1;
        }
    }
}

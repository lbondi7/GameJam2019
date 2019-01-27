using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    // Use this for initialization
    public int health = 3;
    public int money = 10;
    public bool build_mode = false;
    public ClickState menu_selection = ClickState.NONE;
    public enum ClickState
    {
        NONE = -1,
        SPIKES = 0,
        GLUE = 1,
        DOG = 2,
        TOILETPAPER = 3,
        PAINT = 4,
        EGGLAUNCHER = 5,
        GUITAR = 6,
        BAT = 7,
        SPATULA = 8,
        HAMMER = 9
    }

    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {

	}
}

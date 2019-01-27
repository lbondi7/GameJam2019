using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    // Use this for initialization
    public HeartHealth heartHealth;
    public int health;
    public int money = 10;
    public bool build_mode = false;
    public bool turret_mode = false;
    public ClickState menu_selection = ClickState.SPIKES;
    public enum ClickState
    {
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
        health = heartHealth.health;
	}
}

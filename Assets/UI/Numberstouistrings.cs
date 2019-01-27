using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Numberstouistrings : MonoBehaviour {

    public Text health_text_ui; // assign it from inspector
    public string front_text;
    public PlayerManager player_manager;

    // Update is called once per frame
    void Update()
    {
        string healthtostring = front_text + player_manager.health.ToString();
        health_text_ui.text = healthtostring;
    }
}

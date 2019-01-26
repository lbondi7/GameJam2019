using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Moneytostring : MonoBehaviour {

    public Text money_text_ui; // assign it from inspector
    public string front_text;
    public PlayerManager player_manager;

    // Update is called once per frame
    void Update()
    {
        string moneytostring = front_text + player_manager.money.ToString();
        money_text_ui.text = moneytostring;
    }
}

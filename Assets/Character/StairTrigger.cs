﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairTrigger : MonoBehaviour {

    public bool triggered = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        triggered = collision.CompareTag("Player");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            triggered = false;
        }
    }
}

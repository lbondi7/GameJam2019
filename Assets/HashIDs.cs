using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HashIDs : MonoBehaviour {

    public int speed;
    public int attack;

    private void Awake()
    {
        speed = Animator.StringToHash("Speed");
        attack = Animator.StringToHash("Attack");
    }
}

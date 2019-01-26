using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HashIDs : MonoBehaviour {

    public int speed;

    private void Awake()
    {
        speed = Animator.StringToHash("Speed");
    }
}

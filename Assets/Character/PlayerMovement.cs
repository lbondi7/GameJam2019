using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    // Use this for initialization
    public float walkSpeed = 0;
    private Animator anim;
    private HashIDs hash;
    public PlayerManager player_manager;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        hash = GameObject.FindGameObjectWithTag("GameController").GetComponent<HashIDs>();
    }

    // Update is called once per frame
    void Update ()
    {
        float speed = Input.GetAxis("Horizontal") * walkSpeed;
        if (!player_manager.build_mode)
        {
            if (speed == 0)
            {
                speed = Input.GetAxis("HorizontalDPD") * walkSpeed;
            }
            anim.SetFloat(hash.speed, Input.GetAxis("Horizontal") != 0 || Input.GetAxis("HorizontalDPD") != 0 ? 1 : 0);

            transform.Translate(new Vector2(speed, 0));

            if (speed > 0)
            {
                GetComponent<SpriteRenderer>().flipX = false;
            }
            else if (speed < 0)
            {
                GetComponent<SpriteRenderer>().flipX = true;
            }
            anim.SetBool(hash.attack, Input.GetKeyDown(KeyCode.Space));
        }

        

    }
}

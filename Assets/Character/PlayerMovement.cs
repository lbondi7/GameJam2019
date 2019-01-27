using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    // Use this for initialization
    public float walkSpeed = 0;
    private Animator anim;
    private HashIDs hash;
    public PlayerManager player_manager;
    GameObject punchPos;


    private void Awake()
    {
        punchPos = transform.Find("PunchPos").gameObject;
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
                punchPos.transform.localPosition = new Vector2(0.76f, punchPos.transform.localPosition.y);
            }
            else if (speed < 0)
            {
                GetComponent<SpriteRenderer>().flipX = true;
                punchPos.transform.localPosition = new Vector2(-0.75f, punchPos.transform.localPosition.y);

            }


            if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Joystick1Button0))
            {
                StartCoroutine(Punch());
            }
        }
    }

    IEnumerator Punch()
    {
        anim.SetBool(hash.attack, true);
        yield return new WaitForSeconds(0.02f);
        punchPos.GetComponent<Punch>().punch = true;
        //Debug.Log(Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Joystick1Button0));
        yield return new WaitForSeconds(0);
        anim.SetBool(hash.attack, false);
        punchPos.GetComponent<Punch>().punch = false;
        yield return null;

    }

}

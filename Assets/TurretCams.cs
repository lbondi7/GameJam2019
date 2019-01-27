using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretCams : MonoBehaviour {

    public Camera playerCam;
    public Camera[] turretCams;
    public int turrentIndex = 0;
    public PlayerManager playerManager;
    bool select = true;
	// Use this for initialization
	void Start ()
    {
        
    }
	
	// Update is called once per frame
	void Update () {

        if(playerManager.build_mode && playerManager.turret_mode)
        {
            playerCam.gameObject.SetActive(false);
            turretCams[turrentIndex].gameObject.SetActive(true);
            for(int i = 0; i < turrentIndex; ++i)
            {
                turretCams[i].gameObject.SetActive(false);
            }
            for (int i = turrentIndex + 1; i < turretCams.Length - 1; ++i)
            {
                turretCams[i].gameObject.SetActive(false);
            }

            if(Input.GetKeyDown(KeyCode.A) || (Input.GetAxis("HorizontalDPD") < 0 && select))
            {
                turrentIndex = turrentIndex > 0 ? turrentIndex - 1 : turretCams.Length - 1;
                select = false;
            }
            else if (Input.GetKeyDown(KeyCode.D) || (Input.GetAxis("HorizontalDPD") > 0 && select))
            {
                turrentIndex = turrentIndex < turretCams.Length - 1 ? turrentIndex + 1 : 0;
                select = false;
            }
            else if(Input.GetAxis("HorizontalDPD") == 0)
            {
                select = true;
            }
        }
        else
        {
            Debug.Log("hit");
            for (int i = 0; i < turretCams.Length; ++i)
            {
                turretCams[i].gameObject.SetActive(false);
            }
            playerCam.gameObject.SetActive(true);
            turrentIndex = 0;
        }


    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretCams : MonoBehaviour {

    public Camera playerCam;
    public Camera[] turretCams;
    public int turrentIndex = 0;
    public bool enabled = false;
	// Use this for initialization
	void Start ()
    {
        
    }
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.E))
        {
            enabled = !enabled;       
        }

        if(enabled)
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

            if(Input.GetKeyDown(KeyCode.A))
            {
                turrentIndex = turrentIndex > 0 ? turrentIndex - 1 : turretCams.Length - 1;
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                turrentIndex = turrentIndex < turretCams.Length - 1 ? turrentIndex + 1 : 0;
            }
        }
        else
        {
            for (int i = 0; i < turretCams.Length; ++i)
            {
                turretCams[i].gameObject.SetActive(false);
            }
            playerCam.gameObject.SetActive(true);
            turrentIndex = 0;
        }


    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Point_UI : MonoBehaviour
{

    private int count;

    public Text lovePoints;

    private void Start()
    {
        count = 0;
        SetCountText();
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
            count++;
            SetCountText();
        }
    }


    void SetCountText()

    {
        lovePoints.text = "Count: " + count.ToString();
    }
}



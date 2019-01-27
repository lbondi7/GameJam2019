using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Point_UI : MonoBehaviour
{

    private int Money;

    public Text lovePoints;

    private void Start()
    {
        Money = 0;
        SetCountText();
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
            Money++;
            SetCountText();
        }
    }


    void SetCountText()

    {
        lovePoints.text = "Money: " + Money.ToString();
    }
}



using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colectable : MonoBehaviour
{
    private int collectectable;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            Debug.Log("Leaf collected");
            collectectable = collectectable + 1;
            other.gameObject.SetActive(false);
        }
    }
}


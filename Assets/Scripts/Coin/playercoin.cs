using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercoin : MonoBehaviour
{
    public CoinManager cm;
    public int NumofCoin { get; private set; }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coins"))
        {
            Destroy(other.gameObject);
            cm.coinCount++;
        }
    }
}

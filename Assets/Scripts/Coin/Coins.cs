using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        playercoin Playercoin = other.GetComponent<playercoin>();

        if (Playercoin != null)
        {
            Playercoin.CoinCollected();
            gameObject.SetActive(false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercoin : MonoBehaviour
{
    public int NumofCoin { get; private set; }

    public void CoinCollected()
    {
        NumofCoin++;
    }
}
